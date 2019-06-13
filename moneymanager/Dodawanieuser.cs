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
    public partial class Dodawanieuser : Form
    {
        public Dodawanieuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(addlogintextbox.Text == "" || addpasswordtextbox.Text == "")
            {
                MessageBox.Show("Nie wpisałeś nic w wymagane pola", "Błąd!");
            }
            else if(addlogintextbox.Text =="Admin" || addlogintextbox.Text == "admin")
            {
                MessageBox.Show("Użytkownik Admin już istnieje!", "Błąd");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Users] WHERE ([Login] = @user)", conn);
                check_User_Name.Parameters.AddWithValue("@user", addlogintextbox.Text);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {
                    MessageBox.Show("Użytkownik o takim loginie już istnieje", "Błąd!");
                    conn.Close();

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into Users (Login, Haslo) Values (@Login, @Haslo)", conn);
                    cmd.Parameters.AddWithValue("@Login", addlogintextbox.Text);
                    cmd.Parameters.AddWithValue("@Haslo", addpasswordtextbox.Text);
                    cmd.ExecuteNonQuery();

                    //tworzenie folderu i pliku txt z saldem

                    string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + @"\Users");
                    
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", addlogintextbox.Text));
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] xd = new UTF8Encoding(true).GetBytes("0");
                        fs.Write(xd, 0, xd.Length);

                    }

                        SqlCommand createtable = new SqlCommand(string.Format("CREATE TABLE {0}(ID int IDENTITY(1,1) PRIMARY KEY, Nazwa VARCHAR(200), Kwota FLOAT, Saldo FLOAT, Pryiorytet VARCHAR(3), Kategoria VARCHAR(50))", addlogintextbox.Text), conn);
                    createtable.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Poprawnie dodano użytkownika!");
                    this.Close();
                }
            }
        }

        private void addpasswordtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void addlogintextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
