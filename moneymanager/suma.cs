using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace moneymanager
{
    class suma
    {
        public static double sum_zywnosc(SqlConnection conn, string actual_user)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select SUM(Kwota) AS float from {0} Where Kategoria='Zywnosc'", actual_user), conn);
            object t = cmd.ExecuteScalar();
            if (t is System.DBNull)
            {
                return 0;
            }
            else
            {
                double temp;
                temp = Convert.ToDouble(cmd.ExecuteScalar());
                return temp;
            }
            
        }
        public static double sum_transport(SqlConnection conn, string actual_user)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select SUM(Kwota) AS float from {0} Where Kategoria='Transport'", actual_user), conn);
            object t = cmd.ExecuteScalar();
            if (t is System.DBNull)
            {
                return 0;
            }
            else
            {
                double temp;
                temp = Convert.ToDouble(cmd.ExecuteScalar());
                return temp;
            }
        }
        public static double sum_rozrywka(SqlConnection conn, string actual_user)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select SUM(Kwota) AS float from {0} Where Kategoria='Rozrywka'", actual_user), conn);
            object t = cmd.ExecuteScalar();
            if (t is System.DBNull)
            {
                return 0;
            }
            else
            {
                double temp;
                temp = Convert.ToDouble(cmd.ExecuteScalar());
                return temp;
            }
        }
        public static double sum_nauka(SqlConnection conn, string actual_user)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select SUM(Kwota) AS float from {0} Where Kategoria='Nauka'", actual_user), conn);
            object t = cmd.ExecuteScalar();
            if (t is System.DBNull)
            {
                return 0;
            }
            else
            {
                double temp;
                temp = Convert.ToDouble(cmd.ExecuteScalar());
                return temp;
            }
        }
        public static double sum_praca(SqlConnection conn, string actual_user)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select SUM(Kwota) AS float from {0} Where Kategoria='Praca'", actual_user), conn);
            object t = cmd.ExecuteScalar();
            if (t is System.DBNull)
            {
                return 0;
            }
            else
            {
                double temp;
                temp = Convert.ToDouble(cmd.ExecuteScalar());
                return temp;
            }
        }
        public static double sum_niestandardowe(SqlConnection conn, string actual_user)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select SUM(Kwota) AS float from {0} Where Kategoria='Niestandardowe'", actual_user), conn);
            object t = cmd.ExecuteScalar();
            if (t is System.DBNull)
            {
                return 0;
            }
            else
            {
                double temp;
                temp = Convert.ToDouble(cmd.ExecuteScalar());
                return temp;
            }
        }
    }
}
