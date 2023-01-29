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
    }
}