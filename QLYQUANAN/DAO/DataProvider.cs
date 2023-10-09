using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QLYQUANAN.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if(instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider(){}

        private string connectionSTR = @"Data Source=LAPTOP-A8RRGH2F\NNN; Initial Catalog=Quanlyquanan; Integrated Security=True";

     

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] lisPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                conn.Close();
            }
            return dt;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int dt = 0;

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] lisPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return dt;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object dt = 0;

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] lisPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in lisPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = cmd.ExecuteScalar();

                conn.Close();
            }
            return dt;
        }

       
    }
}
