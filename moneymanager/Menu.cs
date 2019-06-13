using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace moneymanager
{
    public partial class Menu : Form
    {
        public string actual_user;

        public Menu(string database_name)
        {
            InitializeComponent();
            actual_user = database_name;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            datalabel.Text = DateTime.Now.ToLongDateString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wydatekbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT(*) FROM {0}", actual_user), conn);
            int result = int.Parse(cmd.ExecuteScalar().ToString());
            if (result == 0) 
            {
                MessageBox.Show("Najpierw dodaj środki!", "Błąd!");
            }
            else
            {
                Wydatki wyd = new Wydatki(actual_user);
                wyd.ShowDialog();
                conn.Close();

            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();         
        }

        private void clearbutton_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("TRUNCATE TABLE {0}", actual_user), conn);
            cmd.ExecuteNonQuery();

            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", actual_user));
            File.WriteAllText(path, "0");

            conn.Close();
            MessageBox.Show("Usuwanie danych zakończone powodzeniem!", "Powodzenie!");
        }

        private void srodekbutton_Click_1(object sender, EventArgs e)
        {
            dodaj dod = new dodaj(actual_user);
            dod.ShowDialog();
        }

        private void saldobutton_Click_1(object sender, EventArgs e)
        {
            Saldo saldo = new Saldo(actual_user);
            saldo.ShowDialog();
        }

        private void check_Click(object sender, EventArgs e)
        {
            sprawdz spr = new sprawdz(actual_user);
            spr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wykresy wyk = new Wykresy(actual_user);
            wyk.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logowanie log = new Logowanie();
            log.Show();
            this.Hide();
        }
    }
}
