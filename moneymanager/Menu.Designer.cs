namespace moneymanager
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datalabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.srodekbutton = new System.Windows.Forms.Button();
            this.saldobutton = new System.Windows.Forms.Button();
            this.wydatekbutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(126, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 104);
            this.panel1.TabIndex = 4;
            // 
            // datalabel
            // 
            this.datalabel.AutoSize = true;
            this.datalabel.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.datalabel.Location = new System.Drawing.Point(3, 283);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(41, 14);
            this.datalabel.TabIndex = 3;
            this.datalabel.Text = "DATA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.button2.Location = new System.Drawing.Point(109, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wykresy Wydatków";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.PeachPuff;
            this.check.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.check.Location = new System.Drawing.Point(195, 110);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(80, 80);
            this.check.TabIndex = 2;
            this.check.Text = "Przeglądaj wydatki";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Gold;
            this.clearbutton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.clearbutton.Location = new System.Drawing.Point(195, 196);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(80, 80);
            this.clearbutton.TabIndex = 5;
            this.clearbutton.Text = "Wyczyść Dane";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click_1);
            // 
            // srodekbutton
            // 
            this.srodekbutton.BackColor = System.Drawing.Color.Gold;
            this.srodekbutton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.srodekbutton.Location = new System.Drawing.Point(23, 196);
            this.srodekbutton.Name = "srodekbutton";
            this.srodekbutton.Size = new System.Drawing.Size(80, 80);
            this.srodekbutton.TabIndex = 3;
            this.srodekbutton.Text = "Dodaj środki";
            this.srodekbutton.UseVisualStyleBackColor = false;
            this.srodekbutton.Click += new System.EventHandler(this.srodekbutton_Click_1);
            // 
            // saldobutton
            // 
            this.saldobutton.BackColor = System.Drawing.Color.Gold;
            this.saldobutton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.saldobutton.Location = new System.Drawing.Point(109, 110);
            this.saldobutton.Name = "saldobutton";
            this.saldobutton.Size = new System.Drawing.Size(80, 80);
            this.saldobutton.TabIndex = 1;
            this.saldobutton.Text = "Sprawdź saldo";
            this.saldobutton.UseVisualStyleBackColor = false;
            this.saldobutton.Click += new System.EventHandler(this.saldobutton_Click_1);
            // 
            // wydatekbutton
            // 
            this.wydatekbutton.BackColor = System.Drawing.Color.PeachPuff;
            this.wydatekbutton.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.wydatekbutton.Location = new System.Drawing.Point(23, 110);
            this.wydatekbutton.Name = "wydatekbutton";
            this.wydatekbutton.Size = new System.Drawing.Size(80, 80);
            this.wydatekbutton.TabIndex = 0;
            this.wydatekbutton.Text = "Dodaj wydatek";
            this.wydatekbutton.UseVisualStyleBackColor = false;
            this.wydatekbutton.Click += new System.EventHandler(this.wydatekbutton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.linkLabel1.Location = new System.Drawing.Point(231, 283);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 14);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Wyloguj";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(298, 302);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.check);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.srodekbutton);
            this.Controls.Add(this.saldobutton);
            this.Controls.Add(this.wydatekbutton);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button srodekbutton;
        private System.Windows.Forms.Button saldobutton;
        private System.Windows.Forms.Button wydatekbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}