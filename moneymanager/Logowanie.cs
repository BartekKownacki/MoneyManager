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

namespace moneymanager
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Dodawanieuser addinguser = new Dodawanieuser();
            addinguser.ShowDialog();
            }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (logintextbox.Text == "" || passwordtextbox.Text == "")
            {
                MessageBox.Show("Nie wpisałeś nic w wymagane pola", "Błąd!");
            }
            if (logintextbox.Text == "Admin" || logintextbox.Text == "admin" && passwordtextbox.Text == "admin1234") 
            {
                admin adm = new admin();
                adm.Show();
                this.Hide();
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
                conn.Open();

                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Users] WHERE ([Login] = @user)", conn);
                SqlCommand check_Password = new SqlCommand("SELECT COUNT(*) FROM [Users] WHERE ([Haslo] = @haslo)", conn);
                check_Password.Parameters.AddWithValue("@haslo", passwordtextbox.Text);
                check_User_Name.Parameters.AddWithValue("@user", logintextbox.Text);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                int PassExist = (int)check_Password.ExecuteScalar();
                if (UserExist > 0 && PassExist > 0)
                {

                    MessageBox.Show("Witaj " + logintextbox.Text);
                    conn.Close();

                    Menu form = new Menu(logintextbox.Text);
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wpisano złe hasło lub podany użytkownik nie istnieje", "Błąd");
                }
            }
        }

        private void Logowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void passwordtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton_Click(this, new EventArgs());
            }
        }

        private void logintextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbutton_Click(this, new EventArgs());
            }
        }
    }
}
