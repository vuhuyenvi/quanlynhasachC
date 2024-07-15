using QuanLyNhaSach.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;

namespace QuanLyNhaSach.Class
{
    public class HoaDon:XuLyHoaDon
    {
        string MaSach;
        DataSet Ds = new DataSet();
        DBConnect db = new DBConnect();
        public string MaSach1
        {
            get { return MaSach; }
            set { MaSach = value; }
        }
        SqlDataAdapter adapt = new SqlDataAdapter();
        private static string conn1 = "Data Source=LAPTOP-GQAMABND;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection conn;
        DataTable dt;
        int d = 0;


        public HoaDon()
        {
            conn = new SqlConnection(conn1);
        }
        public HoaDon(string MaSach, DataSet ds)
        {
            conn = new SqlConnection(conn1);
            this.MaSach = MaSach;
            Ds = ds;
        }
        public int HamKtra(string bang, string giatri , string b)
        {
            string[] chuoi;
            List<int> a1 = new List<int>();
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter();
            adapt1.SelectCommand = new SqlCommand("select * from "+bang+"", conn);
            adapt1.Fill(dt1);
            int a = dt1.Rows.Count;
            int tong = 0;
            string c = b;
            string c1;
            string c2;
            foreach (DataRow dr in dt1.Rows)
            {
                c2 = dr["" + giatri + ""].ToString();
                c1 = c2.Substring(2);
                a1.Add(int.Parse(c1));

                //if(dr["" + giatri + ""].ToString() == "KH10")
                //{
                //    continue;
                //}
                //else if (dr[""+giatri+""].Equals(c + tong.ToString()))
                //{
                //    tong++;
                //    continue;
                //    //string b = dr["MANXB"].ToString();
                //    //a.Add(b);
                //}
                //else
                //{
                //    return tong;
                //}
            }
            tong = a1.Max() + 1;
            return tong;
        }
        public void ThemKhachHang(string ten, string diachi, string sdt, string email)
        {
            d = HamKtra("KHACHHANG", "MAKH", "KH");
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter();
            adapt1.SelectCommand = new SqlCommand("select * from KHACHHANG", conn);
            adapt1.Fill(dt1);
            DataRow newrow1 = Ds.Tables["KHACHHANG"].NewRow();
            newrow1["MAKH"] = "KH" + d.ToString();
            newrow1["HOTENKH"] = ten;
            newrow1["DIACHIKH"] = diachi;
            newrow1["SODT"] = sdt;
            newrow1["EMAILKH"] = email;
            Ds.Tables["KHACHHANG"].Rows.Add(newrow1);
            SqlCommandBuilder cB = new SqlCommandBuilder(adapt1);
            // Cap nhat trong dataSet
            adapt1.Update(Ds, "KHACHHANG");
        }
        public string ThemHoaDon(int ThanhTien, string maNV, string ngayLap)
        {
            string e;
            //Ds.Tables[0].Columns[0].ColumnName = maHoaDon;
            DataTable dt1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter();
            adapt1.SelectCommand = new SqlCommand("select * from HOADON", conn);
            adapt1.Fill(dt1);
            DataRow newrow1 = Ds.Tables["HOADON"].NewRow();
            newrow1["MAHD"] = /*"HD" + (a + 1).ToString();*/ "HD" + HamKtra("HOADON", "MAHD", "HD").ToString();
            e = "HD" + HamKtra("HOADON", "MAHD", "HD").ToString();
            newrow1["MANV"] = maNV;
            newrow1["MAKH"] = "KH" + d.ToString();
            newrow1["NGAYLAP"] = ngayLap;
            newrow1["TRANGTHAIDH"] = "Hoàn Thành";
            newrow1["THANHTIEN"] = ThanhTien;
            Ds.Tables["HOADON"].Rows.Add(newrow1);
            SqlCommandBuilder cB = new SqlCommandBuilder(adapt1);
            // Cap nhat trong dataSet
            adapt1.Update(Ds, "HOADON");
            return e;

        }
         public void ThemChiTietHoaDon(DataGridView dt1,string maHD)
        {
            SqlDataAdapter adapt1 = new SqlDataAdapter();
            adapt1.SelectCommand = new SqlCommand("select * from CHITIETHD",conn);
            string[] c;
            foreach (DataGridViewRow row in dt1.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng trống
                if (!row.IsNewRow)
                {
                    DataRow newrow1 = Ds.Tables["CHITIETHD"].NewRow();
                    newrow1["MASACH"] = row.Cells["MASACH"].Value.ToString();
                    newrow1["MAHD"] = maHD;
                    newrow1["GIABAN"] = row.Cells["DONGIA"].Value.ToString();
                    
                    c = row.Cells["THANHTIEN"].Value.ToString().Split(' ');
                    newrow1["TONGTIEN"] = c[0];
                    

                    string sql = "SELECT SOLUONGTON FROM SACH WHERE MASACH = '" + row.Cells["MASACH"].Value.ToString() + "'";
                    int sl = (int)db.getScalar(sql);
                    int slBan = int.Parse(row.Cells["SOLUONG"].Value.ToString());
                    int slTon = sl - slBan;
                    if(slTon >=0)
                    {
                        sql = "UPDATE SACH SET SOLUONGTON = " + slTon + " WHERE MASACH = '"+ row.Cells["MASACH"].Value.ToString() + "'";
                        db.getNonQuery(sql);
                        newrow1["SOLUONG"] = row.Cells["SOLUONG"].Value.ToString();
                        Ds.Tables["CHITIETHD"].Rows.Add(newrow1);
                        SqlCommandBuilder cB = new SqlCommandBuilder(adapt1);
                        // Cap nhat trong dataSet
                        adapt1.Update(Ds, "CHITIETHD");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Không đủ số lượng sách cần bán");
                        return;
                    }
                }
            }
        }
        //public void Fill()
        //{
        //    DataTable dt = new DataTable();
        //    adapt.SelectCommand = new SqlCommand("select * from SACH", conn);
        //    adapt.Fill(dt);
        //}

        public string LayTheLoai()
        {
            string a;
            string b = "Lỗi r";
            DataTable dt = new DataTable();
            adapt.SelectCommand = new SqlCommand("select TENTL, MASACH from THELOAI,SACH where THELOAI.MATL = SACH.MATL and SACH.MASACH = '" + MaSach + "' group by TENTL, MASACH ", conn);
            adapt.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MASACH"].Equals(MaSach))
                    {
                        a = dr["TENTL"].ToString();
                        return a;
                        //string b = dr["MANXB"].ToString();
                        //a.Add(b);
                    }
                }
                return b;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Lỗi rồi");
                return "hihi";
            }

        }
        public string LayNXB()
        {
            string a;
            string b = "Lỗi r";
            DataTable dt = new DataTable();
            adapt.SelectCommand = new SqlCommand("select TENNXB, MASACH from NHAXUATBAN,SACH where NHAXUATBAN.MANXB = SACH.MANXB and SACH.MASACH = '" + MaSach + "' group by TENNXB, MASACH ", conn);
            adapt.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MASACH"].Equals(MaSach))
                    {
                        a = dr["TENNXB"].ToString();
                        return a;
                        //string b = dr["MANXB"].ToString();
                        //a.Add(b);
                    }
                }
                return b;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Lỗi rồi");
                return "hihi";
            }
        }
        public string LayTacGia()
        {
            string a;
            string b = "Lỗi r";
            DataTable dt = new DataTable();
            adapt.SelectCommand = new SqlCommand("select TENTG, MASACH from TACGIA,SACH where TACGIA.MATG = SACH.MATG and SACH.MASACH = '" + MaSach + "' group by TENTG, MASACH ", conn);
            adapt.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["MASACH"].Equals(MaSach))
                    {
                        a = dr["TENTG"].ToString();
                        return a;
                        //string b = dr["MANXB"].ToString();
                        //a.Add(b);
                    }
                }
                return b;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Lỗi rồi");
                return "hihi";
            }
        }
        public string KTraKhuyenMai(string now)
        {
            string c;
            string b = "0";
            //DateTime date = DateTime.Parse(now);
            //String.Format("{0:dd-MM-yyyy}", date);
            string a = "select GIAMGIA from KHUYENMAI,SACHKHUYENMAI where KHUYENMAI.MAKM = SACHKHUYENMAI.MAKM and GETDATE() between NGAYBD and NGAYKT and SACHKHUYENMAI.MASACH = '"+MaSach+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(a,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["GIAMGIA"]!=null)
                    {
                        c = dr["GIAMGIA"].ToString();
                        return c;
                        //string b = dr["MANXB"].ToString();
                        //a.Add(b);
                    }
                }
                return b;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Lỗi rồi");
                return "0";
            }

        }
    }
}
