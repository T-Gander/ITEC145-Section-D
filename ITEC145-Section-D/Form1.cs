namespace ITEC145_Section_D
{
    public partial class Form1 : Form
    {
        string fileRecords = "";
        List<string> columnNames = new List<string> {"Make", "Model", "Year", "Mileage" };
        List<string> columnValues = new List<string>();
        int columns = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            dataGridCars.ColumnCount = columnNames.Count;    //Sets and creates the amount of columns that are needed.
            for (int i = 0; i < columns; i++)                //Loop to add each column with the names specified in the columnNames list.
            {
                dataGridCars.Columns[i].Name = columnNames[i];  //Sets each columns name based on the names in columnNames
            }

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)                 //If file dialog is successful in selecting a file. Do something.
            {
                int count = 0;                                      //To keep count of records read.
                StreamReader reader = new StreamReader(ofd.FileName);

                for(int i = 0; !reader.EndOfStream; i++)
                {
                    columnValues.Add(reader.ReadLine());
                    count++;
                }
                reader.Close();

               txtFileSelect.Text = $"{count} records were added to the List";           
            }
            else
            {
                MessageBox.Show("Please select a file!");
            }
            
            


        }
    }
}