using System.Globalization;

namespace ITEC145_Section_D
{
    public partial class Form1 : Form
    {
        string fileRecords = "";
        List<string> columnNames = new List<string> {"Make", "Model", "Year", "Mileage" };
        List<string> allCars = new List<string>();     //Need to change this to a struct
        

        
    struct cars
        {
            public string Make;
            public string Model;
            public int Year;
            public int Mileage;
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
            //ofd.ShowDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)                     //If file dialog is successful in selecting a file. Do something.
            {
                
                int count = 0;                                                       //To keep count of records read.
                StreamReader reader = new StreamReader(ofd.FileName);
                var[] words = new var[columnNames.Count];


                for(int i=0; !reader.EndOfStream, i++)
                {
                    cars carList;
                    words = reader.ReadLine().Split(",");
                    for(int j = 0; j < words.Length; j++)
                    {
                        carList[j] == words[j];
                    }

                    if (i == 3)
                        i = 0;
                }


                //for(int i = 0; !reader.EndOfStream; i++)
                //{
                //    columnValues.Add(reader.ReadLine());
                //    count++;
                //}
                reader.Close();

               txtFileSelect.Text = $"{count} records were added to the List";  
            }
            else
            {
                MessageBox.Show("Please select a file!");
            }
        }

        private void btnLoadGrid_Click(object sender, EventArgs e)
        {

        }
    }
}