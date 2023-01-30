using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC145_Section_D
{

    public partial class Form2 : Form
    {
        

    public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms[0];               //Searches for open Form1 forms (there should only be one) and assigns it to the form variable frm1.

            dataGridView1.ColumnCount = frm1.columnNames.Count;               //Sets the column count based on Form1's columns.
            for (int i = 0; i < dataGridView1.ColumnCount; i++)          //Loop to add each column with the names specified in the Form1 columnNames list.
            {
                dataGridView1.Columns[i].HeaderText = frm1.columnNames[i];    //Copied from Form 1 with minor changes.
            }

            for (int i = 0 + frm1.actualRowCount; i < frm1.allCars.Count + frm1.actualRowCount; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = frm1.allCars[i - frm1.actualRowCount].Make;         //Copied from Form1.
                dataGridView1.Rows[i].Cells[1].Value = frm1.allCars[i - frm1.actualRowCount].Model;        //Also had to change a few variables in Form1 to public.
                dataGridView1.Rows[i].Cells[2].Value = frm1.allCars[i - frm1.actualRowCount].Year;         
                dataGridView1.Rows[i].Cells[3].Value = frm1.allCars[i - frm1.actualRowCount].Mileage;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
