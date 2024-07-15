using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    public class DataProvider
    {
        private static string connect = "Data Source=LAPTOP-GQAMABND;Initial Catalog=QLNS;Integrated Security=True";
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
    }
}