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
            columns = columnNames.Count;                    //Sets the amount of columns that are needed to be created.

            for(int i = 0; i < columns; i++)                //Loop to add each column with the names specified in the columnNames list.
            {
                //dataGridCars.Columns.Add(new DataGridViewColumn());
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)                 //If file dialog is successful in selecting a file. Do something.
            {
                int count = 0;                                      //To keep count of records read.
                StreamReader reader = new StreamReader(ofd.FileName);

                for(int i = 0; !reader.EndOfStream; i++)
                {
                    columnValues.Add(reader.ReadLine());
                }


               txtFileSelect.Text = $"{count} records were added to the ";           
            }
            
            


        }
    }
}