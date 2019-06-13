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
    public partial class Wykresy : Form
    {
        string actual_user;
        public Wykresy(string user)
        {
            InitializeComponent();
            actual_user = user;
        }
        
        private void settings(string ser1, string ser2, string ser3, string ser4, string ser5, string ser6)
        {
            chart1.Series.Add(ser1);
            chart1.Series.Add(ser2);
            chart1.Series.Add(ser3);
            chart1.Series.Add(ser4);
            chart1.Series.Add(ser5);
            chart1.Series.Add(ser6);

            chart1.Series[ser1].IsValueShownAsLabel = true;
            chart1.Series[ser2].IsValueShownAsLabel = true;
            chart1.Series[ser3].IsValueShownAsLabel = true;
            chart1.Series[ser4].IsValueShownAsLabel = true;
            chart1.Series[ser5].IsValueShownAsLabel = true;
            chart1.Series[ser6].IsValueShownAsLabel = true;
        }

        private void Wykresy_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bartek\source\repos\moneymanager\moneymanager\Users.mdf;Integrated Security=True");
            conn.Open();

            double suma_zywnosc = suma.sum_zywnosc(conn, actual_user);
            double suma_transport = suma.sum_transport(conn, actual_user);
            double suma_rozrywka = suma.sum_rozrywka(conn, actual_user);
            double suma_nauka = suma.sum_nauka(conn, actual_user);
            double suma_praca = suma.sum_praca(conn, actual_user);
            double suma_niestandardowe = suma.sum_niestandardowe(conn, actual_user);
            string ser1, ser2, ser3, ser4, ser5, ser6;
            ser1 = "Żywność";
            ser2 = "Transport";
            ser3 = "Rozrywka";
            ser4 = "Nauka";
            ser5 = "Praca";
            ser6 = "Niestandardowe";

            settings(ser1, ser2, ser3, ser4, ser5, ser6);

            chart1.Series[ser1].Points.AddXY(ser1, suma_zywnosc);
            chart1.Series[ser2].Points.AddXY(ser2, suma_transport);
            chart1.Series[ser3].Points.AddXY(ser3, suma_rozrywka);
            chart1.Series[ser4].Points.AddXY(ser4, suma_nauka);
            chart1.Series[ser5].Points.AddXY(ser5, suma_praca);
            chart1.Series[ser6].Points.AddXY(ser6, suma_niestandardowe);

            chart1.ChartAreas[0].AxisX.Interval = 1;



            //rozdzielanie serii
            chart1.AlignDataPointsByAxisLabel();

        }
    }
}
