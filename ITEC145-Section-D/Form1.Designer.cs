namespace ITEC145_Section_D
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.txtDatagrid = new System.Windows.Forms.TextBox();
            this.txtFileSelect = new System.Windows.Forms.TextBox();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(12, 99);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.RowTemplate.Height = 25;
            this.dataGridCars.Size = new System.Drawing.Size(668, 315);
            this.dataGridCars.TabIndex = 11;
            // 
            // txtDatagrid
            // 
            this.txtDatagrid.Location = new System.Drawing.Point(287, 71);
            this.txtDatagrid.Name = "txtDatagrid";
            this.txtDatagrid.Size = new System.Drawing.Size(393, 23);
            this.txtDatagrid.TabIndex = 10;
            // 
            // txtFileSelect
            // 
            this.txtFileSelect.Location = new System.Drawing.Point(287, 13);
            this.txtFileSelect.Name = "txtFileSelect";
            this.txtFileSelect.Size = new System.Drawing.Size(393, 23);
            this.txtFileSelect.TabIndex = 9;
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Location = new System.Drawing.Point(12, 70);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(269, 23);
            this.btnLoadGrid.TabIndex = 8;
            this.btnLoadGrid.Text = "Move Data from Struct to Datagrid";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(12, 41);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(269, 23);
            this.btnPeek.TabIndex = 7;
            this.btnPeek.Text = "Peek Inside Structure List?";
            this.btnPeek.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(269, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "File Select for Data Struct";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(688, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 74);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(688, 275);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(164, 23);
            this.txtFilename.TabIndex = 13;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(688, 257);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(88, 15);
            this.lblFilename.TabIndex = 14;
            this.lblFilename.Text = "Name your file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.txtDatagrid);
            this.Controls.Add(this.txtFileSelect);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridCars;
        private TextBox txtDatagrid;
        private TextBox txtFileSelect;
        private Button btnLoadGrid;
        private Button btnPeek;
        private Button btnLoad;
        private Button btnSave;
        private TextBox txtFilename;
        private Label lblFilename;
    }
}