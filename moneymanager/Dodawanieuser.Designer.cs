namespace moneymanager
{
    partial class Dodawanieuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodawanieuser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addlogintextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addpasswordtextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // addlogintextbox
            // 
            this.addlogintextbox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addlogintextbox.Location = new System.Drawing.Point(99, 12);
            this.addlogintextbox.MaxLength = 20;
            this.addlogintextbox.Name = "addlogintextbox";
            this.addlogintextbox.Size = new System.Drawing.Size(100, 26);
            this.addlogintextbox.TabIndex = 0;
            this.addlogintextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addlogintextbox_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.button1.Location = new System.Drawing.Point(47, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj użytkownika";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addpasswordtextbox
            // 
            this.addpasswordtextbox.Font = new System.Drawing.Font("Georgia", 12F);
            this.addpasswordtextbox.Location = new System.Drawing.Point(99, 40);
            this.addpasswordtextbox.Name = "addpasswordtextbox";
            this.addpasswordtextbox.PasswordChar = '*';
            this.addpasswordtextbox.Size = new System.Drawing.Size(100, 26);
            this.addpasswordtextbox.TabIndex = 1;
            this.addpasswordtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addpasswordtextbox_KeyDown);
            // 
            // Dodawanieuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(221, 118);
            this.Controls.Add(this.addpasswordtextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addlogintextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dodawanieuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addlogintextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox addpasswordtextbox;
    }
}