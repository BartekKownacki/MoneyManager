using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneymanager
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            datalabel.Text = DateTime.Now.ToLongDateString();
        }

        private void wydatekbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Users", conn);
            cmd.ExecuteNonQuery();
            SqlCommand deleteuserstables = new SqlCommand("exec sp_MSforeachtable 'DROP TABLE ?'", conn);
            deleteuserstables.ExecuteNonQuery();
            SqlCommand createusers = new SqlCommand("CREATE TABLE Users(Id int IDENTITY(1,1) PRIMARY KEY, Login VARCHAR(50), Haslo VARCHAR(50))", conn);
            createusers.ExecuteNonQuery();


            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + @"\Users\");
            Directory.Delete(path, true);
            Directory.CreateDirectory(path);
            conn.Close();
            MessageBox.Show("Usuwanie danych zakończone powodzeniem!", "Powodzenie!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logowanie log = new Logowanie();
            log.Show();
            this.Hide();
        }
    }
}
