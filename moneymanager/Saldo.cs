using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace moneymanager
{
    public partial class Saldo : Form
    {
        string actual_user;
        public Saldo(string user)
        {
            InitializeComponent();
            actual_user = user;
        }

        private void Saldo_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", actual_user));
            string saldo = File.ReadAllText(path);

            label1.Text = string.Format("SALDO UŻYTKOWNIKA\n{0}", actual_user);
            label2.Text = saldo + " zł";
            label2.TextAlign = ContentAlignment.TopCenter;
            if (Convert.ToDouble(saldo)<0)
            {
                MessageBox.Show("Twoje saldo jest poniżej 0 zł", "Uwaga!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
