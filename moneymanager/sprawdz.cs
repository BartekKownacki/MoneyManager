using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace moneymanager
{
    public partial class sprawdz : Form
    {
        string actual_user;
        public sprawdz(string user)
        {
            InitializeComponent();
            actual_user = user;
        }

        private void sprawdz_Load(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("SELECT * FROM {0}", actual_user), conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void sortbut_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();
            if(przychodcheck.Checked)
            {
                DataTable dtbl = new DataTable();
                if (comboBox1.SelectedIndex == 0)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("Select * From {0} Where Pryiorytet = 'TAK' ", actual_user), conn);
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("Select * From {0} Order by Nazwa", actual_user), conn);
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("Select * From {0} Order by Kwota", actual_user), conn);
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                else
                {
                    MessageBox.Show("Wybierz atrybut sortowania!", "Błąd!");
                }

            }
            else
            {
                DataTable dtbl = new DataTable();
                if (comboBox1.SelectedIndex == 0)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("Select * From {0} Where Pryiorytet = 'TAK' and Nazwa !='PRZYCHÓD' ", actual_user), conn);
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("Select * From {0} Where Nazwa !='PRZYCHÓD' Order by Nazwa", actual_user), conn);
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(string.Format("Select * From {0} Where Nazwa !='PRZYCHÓD' Order by Kwota", actual_user), conn);
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                else
                {
                    MessageBox.Show("Wybierz atrybut sortowania!", "Błąd!");
                }
                
            }



        }
    }
}
