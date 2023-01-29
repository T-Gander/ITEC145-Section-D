using System.Globalization;

namespace ITEC145_Section_D
{
    public partial class Form1 : Form
    {
        string fileRecords = "";
        List<string> columnNames = new List<string> {"Make", "Model", "Year", "Mileage" };
        List<cars> allCars = new List<cars>();

        string projectDirectory = Directory.GetCurrentDirectory();      //Got this idea from JJ :D



    struct cars
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
                    
                        carList.Make = words[0];                    
                        carList.Model = words[1];                    
                        carList.Year = int.Parse(words[2]);        
                        carList.Mileage = double.Parse(words[3]);

                        allCars.Add(carList);
                        count++;
                    }
                    reader.Close();
                    txtFileSelect.Text = $"{count} records were added to the List";
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
            for(int i = 0; i < allCars.Count; i++)
            {
                dataGridCars.Rows.Add();
                dataGridCars.Rows[i].Cells[0].Value = allCars[i].Make;
                dataGridCars.Rows[i].Cells[1].Value = allCars[i].Model;
                dataGridCars.Rows[i].Cells[2].Value = allCars[i].Year;
                dataGridCars.Rows[i].Cells[3].Value = allCars[i].Mileage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string filename = txtFilename.Text;
                allCars.Clear();
                cars newCars = new cars();

                for (int i = 0; i < dataGridCars.RowCount - 1; i++)
                {
                    newCars.Make = dataGridCars.Rows[i].Cells[0].Value.ToString();
                    newCars.Model = dataGridCars.Rows[i].Cells[1].Value.ToString();
                    newCars.Year = int.Parse(dataGridCars.Rows[i].Cells[2].Value.ToString());

                    if (newCars.Year > DateTime.Now.Year+1)
                    {
                        MessageBox.Show("You have a car in the datagrid that doesnt exist yet. Filesave operation cancelled.");
                        throw new Exception();
                    }
                    else if(newCars.Year < DateTime.Now.Year - 100 && count < 1)
                    {
                        count++;
                        MessageBox.Show("A car in your datagrid is likely too old to exist, advised to check your data and save again. This will not show again");
                    }

                    newCars.Mileage = double.Parse(dataGridCars.Rows[i].Cells[3].Value.ToString());
                    allCars.Add(newCars);
                }

                StreamWriter writer = new StreamWriter(filename + ".txt");      //Placed here to prevent creation of a file in the event of an error

                foreach (cars cars in allCars)
                {
                    writer.WriteLine(cars.Make + "," + cars.Model + "," + cars.Year + "," + cars.Mileage);
                }
                writer.Close();

                MessageBox.Show($"{filename}.txt saved succesfully!");
            }
            catch
            {
                MessageBox.Show("Please check that you have saved only integers and doubles in their respective fields (Year and Mileage), and try again. Filesave was cancelled.");
            }
            
        }
    }
}