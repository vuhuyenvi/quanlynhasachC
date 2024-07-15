using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
    internal class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get
            {
                if (instance == null)
                    instance = new Account();
                return instance;
            }
            private set { instance = value; }
        }
        public Account() { }
        public bool Login(string username, string password)
        {
            //SqlConnection conn = new SqlConnection("Data Source=RIAS1;Initial Catalog=QLNS;Integrated Security=True");
            //conn.Open();
            string query = "SELECT * FROM TAIKHOAN WHERE TENDN = '" + username + "' AND MATKHAU = '" + password + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            //conn.Close();
            return data.Rows.Count > 0;

        }
    }
}
