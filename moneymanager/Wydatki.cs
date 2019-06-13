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
    public partial class Wydatki : Form
    {
        public string actual_user;
        public Wydatki(string user)
        {
            InitializeComponent();
            actual_user = user;
        }
        public void update_datagridview()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("SELECT * FROM {0}", actual_user), conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;


            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", actual_user));
            float saldo = float.Parse(File.ReadAllText(path));
            label2.Text = saldo.ToString() + " zł";
        }
        
        private void Wydatki_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", actual_user));
            float saldo = float.Parse(File.ReadAllText(path));
            label2.Text = saldo.ToString() + " zł";

            update_datagridview();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string nazwa;
            float kwota;
            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", actual_user));
            float saldo = float.Parse(File.ReadAllText(path));
            float suma;
            string kategoria = null;

            if (nazwatextbox.Text == "")
            {
                MessageBox.Show("Nie wpisano nazwy wydatku!", "Błąd!");

            }
            else if (kwotafloat.Value == 0)
            {
                MessageBox.Show("Nie wprowadzono kwoty wydatku!", "Błąd!");
            }
            else
            {
                if (comboBox1.SelectedIndex >5 && comboBox1.SelectedIndex <0)
                {
                    MessageBox.Show("Nie wprowadzono kategorii wydatku!", "Błąd!");
                }
                else
                {
                    nazwa = nazwatextbox.Text;
                    kwota = (float)kwotafloat.Value;
                    switch ((int)comboBox1.SelectedIndex)
                    {
                        case 0:
                            kategoria = "Zywnosc";
                            break;
                        case 1:
                            kategoria = "Transport";
                            break;
                        case 2:
                            kategoria = "Rozrywka";
                            break;
                        case 3:
                            kategoria = "Nauka";
                            break;
                        case 4:
                            kategoria = "Praca";
                            break;
                        case 5:
                            kategoria = "Niestandardowe";
                            break;
                    }
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
                    conn.Open();

                    if (pryiorytetcheck.Checked)
                    {
                        SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO {0} (Nazwa, Kwota, Saldo, Pryiorytet, Kategoria) VALUES (@Nazwa, {1}, {2}, 'TAK', @Kategoria)", actual_user, kwota, saldo - kwota), conn);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Kategoria", kategoria);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO {0} (Nazwa, Kwota, Saldo, Pryiorytet, Kategoria) VALUES (@Nazwa, {1}, {2}, 'NIE', @Kategoria)", actual_user, kwota, saldo - kwota), conn);
                        cmd.Parameters.AddWithValue("@Nazwa", nazwa);
                        cmd.Parameters.AddWithValue("@Kategoria", kategoria);
                        cmd.ExecuteNonQuery();
                    }

                    suma = saldo - kwota;

                    File.WriteAllText(path, suma.ToString());

                    update_datagridview();

                    conn.Close();

                }
            }
        }

        private void nazwatextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void kwotafloat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
