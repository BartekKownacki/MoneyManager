namespace moneymanager
{
    partial class sprawdz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sprawdz));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.przychodcheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortbut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersDataSet = new moneymanager.UsersDataSet();
            this.lelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lelTableAdapter = new moneymanager.UsersDataSetTableAdapters.lelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.comboBox1.Items.AddRange(new object[] {
            "Pryiorytet",
            "Alfabetycznie (po nazwie)",
            "Po wydanej kwocie"});
            this.comboBox1.Location = new System.Drawing.Point(44, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 22);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sortuj";
            // 
            // przychodcheck
            // 
            this.przychodcheck.AutoSize = true;
            this.przychodcheck.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.przychodcheck.Location = new System.Drawing.Point(134, 56);
            this.przychodcheck.Name = "przychodcheck";
            this.przychodcheck.Size = new System.Drawing.Size(15, 14);
            this.przychodcheck.TabIndex = 2;
            this.przychodcheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.label2.Location = new System.Drawing.Point(1, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uwzględnij przychód";
            // 
            // sortbut
            // 
            this.sortbut.BackColor = System.Drawing.Color.PeachPuff;
            this.sortbut.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.sortbut.Location = new System.Drawing.Point(78, 149);
            this.sortbut.Name = "sortbut";
            this.sortbut.Size = new System.Drawing.Size(75, 23);
            this.sortbut.TabIndex = 1;
            this.sortbut.Text = "Sortuj";
            this.sortbut.UseVisualStyleBackColor = false;
            this.sortbut.Click += new System.EventHandler(this.sortbut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.przychodcheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 83);
            this.panel1.TabIndex = 0;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lelBindingSource
            // 
            this.lelBindingSource.DataMember = "lel";
            this.lelBindingSource.DataSource = this.usersDataSet;
            // 
            // lelTableAdapter
            // 
            this.lelTableAdapter.ClearBeforeFill = true;
            // 
            // sprawdz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(906, 210);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortbut);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sprawdz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyManager";
            this.Load += new System.EventHandler(this.sprawdz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox przychodcheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortbut;
        private System.Windows.Forms.Panel panel1;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource lelBindingSource;
        private UsersDataSetTableAdapters.lelTableAdapter lelTableAdapter;
    }
}