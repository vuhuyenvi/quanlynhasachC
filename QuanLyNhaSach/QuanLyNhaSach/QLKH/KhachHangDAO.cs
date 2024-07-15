using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaSach.Class;

namespace QuanLyNhaSach.QLKH
{
    internal class KhachHangDAO
    {
        SqlConnection conn;
        DataTable dt;
        SqlDataAdapter adapt;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public static string sql = "select * from KHACHHANG";
        public KhachHangDAO() 
        {
            conn = new SqlConnection(KetNoi.trConn);
            adapt = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            ds = new DataSet();
            adapt.Fill(ds,"KHACHHANG");
            key[0] = ds.Tables["KHACHHANG"].Columns[0];
            ds.Tables["KHACHHANG"].PrimaryKey = key;
        }
        public bool update(KhachHangDTO kh)
        {
            try
            {
                adapt.SelectCommand = new SqlCommand(sql, conn);
                DataRow update_New = ds.Tables["KHACHHANG"].Rows.Find(kh.MaKH);
                if (update_New != null)
                {
                    update_New["MAKH"] = kh.MaKH;
                    update_New["HOTENKH"] = kh.HoTen;
                    update_New["DIACHIKH"] = kh.DiaChi;
                    update_New["SODT"] = kh.SoDT;
                    update_New["EMAILKH"] = kh.Email1;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(adapt);
                    int kq = adapt.Update(ds, "KHACHHANG");
                    if (kq > 0)
                    {
                        return true;
                    }
                }
                return false;
           
            }
            catch(Exception )
            {
                return false;
            }
            
        }
        public bool Delete(KhachHangDTO kh)
        {
            try
            {
                adapt.SelectCommand = new SqlCommand(sql, conn);
                DataRow update_New = ds.Tables["KHACHHANG"].Rows.Find(kh.MaKH);
                if (update_New != null)
                {
                    update_New.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(adapt);
                int kq = adapt.Update(ds, "KHACHHANG");
                if (kq > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex) 
            {
                return false;
            }
            
        }
        public DataTable getAll()
        {
            return ds.Tables["KHACHHANG"];
        }
    }
}
