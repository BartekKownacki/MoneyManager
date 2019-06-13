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
    public partial class dodaj : Form
    {
        string actual_user;
        public dodaj(string user)
        {
            InitializeComponent();
            actual_user = user;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kwota = (float)wartoscdod.Value;
            string path = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory) + string.Format(@"\Users\{0}.txt", actual_user));
            float saldo = float.Parse(File.ReadAllText(path));
            float suma;

            if (kwota == 0)
            {
                MessageBox.Show("Nie można dodać 0 środków", "Błąd!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
                conn.Open();

                
                SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO {0} (Nazwa, Kwota, Saldo, Pryiorytet, Kategoria) VALUES ('PRZYCHÓD', {1} , {2}, 'TAK', 'PRZYCHÓD')", actual_user, kwota, kwota + saldo), conn);
                cmd.ExecuteNonQuery();

                suma = kwota + saldo;

                File.WriteAllText(path, suma.ToString());
                MessageBox.Show(string.Format("Poprawnie dodano {0} zł do konta!", kwota));
                conn.Close();
                this.Close();
            }
        }

        private void dodaj_Load(object sender, EventArgs e)
        {
            
        }

        private void wartoscdod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
