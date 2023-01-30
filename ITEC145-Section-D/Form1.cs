using System.Globalization;

namespace ITEC145_Section_D
{
    public partial class Form1 : Form
    {
        public List<string> columnNames = new List<string> {"Make", "Model", "Year", "Mileage" };
        public List<cars> allCars = new List<cars>();
        public int actualRowCount;
        string projectDirectory = Directory.GetCurrentDirectory();      //Got this idea from JJ :D
        public struct cars
        {
            public string Make;
            public string Model;
            public int Year;
            public double Mileage;
        }
        public Form1()
        {
            InitializeComponent();
            dataGridCars.ColumnCount = columnNames.Count;               //Sets and creates the amount of columns that are needed.
            for (int i = 0; i < dataGridCars.ColumnCount; i++)          //Loop to add each column with the names specified in the columnNames list.
            {
                dataGridCars.Columns[i].HeaderText = columnNames[i];    //Sets each columns name based on the names in columnNames
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = projectDirectory;

            try
            {
                if(ofd.ShowDialog() == DialogResult.OK)                     //If file dialog is successful in selecting a file. Do something.
                {
                    int count = 0;                                                       //To keep count of records read.
                    StreamReader reader = new StreamReader(ofd.FileName);
                    string[] words = new string[columnNames.Count];

                    for(int i=0; !reader.EndOfStream; i++)
                    {
                        cars carList = new cars();
                        words = reader.ReadLine().Split(",");
                    
                        carList.Make = words[0];                            //Would like to figure out how to loop through a struct,
                        carList.Model = words[1];                           //to figure out how many variables there are in order
                        carList.Year = int.Parse(words[2]);                 //to make this code more responsive based on the column
                        carList.Mileage = double.Parse(words[3]);           //names you give it above.
                        allCars.Add(carList);
                        count++;
                    }
                    reader.Close();
                    txtFileSelect.Text = $"{count} records were added to the list of cars";
                }
                else
                {
                    MessageBox.Show("Please select a valid file!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadGrid_Click(object sender, EventArgs e)
        {
            int count = 0;
            actualRowCount = dataGridCars.RowCount - 1;     //Used to add multiple records to datagrid.

            for(int i = 0 + actualRowCount; i < allCars.Count + actualRowCount; i++)
            {
                dataGridCars.Rows.Add();
                dataGridCars.Rows[i].Cells[0].Value = allCars[i - actualRowCount].Make;         //Again would like to make this more responsive
                dataGridCars.Rows[i].Cells[1].Value = allCars[i - actualRowCount].Model;        //to a single global field change
                dataGridCars.Rows[i].Cells[2].Value = allCars[i - actualRowCount].Year;         //ran out of time to figure this out.
                dataGridCars.Rows[i].Cells[3].Value = allCars[i - actualRowCount].Mileage;
                count++;
            }
            txtDatagrid.Text = $"{count} records added to datagrid.";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int yearCount = 0;
                string filename = txtFilename.Text;

                if(filename == "")
                {
                    MessageBox.Show("Please name your file!");
                }
                else
                {
                    allCars.Clear();
                    cars newCars = new cars();

                    for (int i = 0; i < dataGridCars.RowCount - 1; i++)
                    {
                        newCars.Make = dataGridCars.Rows[i].Cells[0].Value.ToString();                          //Potential to add if statements to chack for numbers within a string,
                        newCars.Model = dataGridCars.Rows[i].Cells[1].Value.ToString();                         // but I'm too lazy today.
                        newCars.Year = int.Parse(dataGridCars.Rows[i].Cells[2].Value.ToString());

                        if (newCars.Year > DateTime.Now.Year+1)                                                 //Error checking of the cars year based on current time as a proof of concept.
                        {
                            MessageBox.Show("You have a car in the datagrid that doesnt exist yet. Filesave operation cancelled.");
                            throw new Exception();  //Used to cancel operation and move to catch statement
                        }
                        else if(newCars.Year < DateTime.Now.Year - 100 && yearCount < 1)
                        {
                            yearCount++;
                            MessageBox.Show("A car in your datagrid is likely too old to exist, advised to check your data and save again. This will not show again");
                        }

                        newCars.Mileage = double.Parse(dataGridCars.Rows[i].Cells[3].Value.ToString());
                        allCars.Add(newCars);
                    }

                    StreamWriter writer = new StreamWriter(filename + ".txt");      //Placed here to prevent creation of a file in the event of an error

                    foreach (cars cars in allCars)
                    {
                        writer.WriteLine(cars.Make + "," + cars.Model + "," + cars.Year + "," + cars.Mileage);  //Assembles all data back together to be stored inside a file
                    }
                    writer.Close();
                    MessageBox.Show($"{filename}.txt saved succesfully!");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please check that you have saved only integers and doubles in their respective fields (Year and Mileage), and try again. Filesave was cancelled.");
            }
            
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();       //Creates Form2
            frm2.ShowDialog();              //Makes Form2 actually appear.
        }
    }
}