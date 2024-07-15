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
using QuanLyNhaSach;
using QuanLyNhaSach.Class;

namespace QuanLyNhaSach
{
    public partial class ThongKe : Form
    {
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlDataAdapter adapt;
        string HoTen;
        public ThongKe(string hoTen)
        {
            conn = new SqlConnection(KetNoi.trConn);
            adapt = new SqlDataAdapter("select * from HOADON", conn);
            adapt.Fill(ds, "HOADON");
            InitializeComponent();
            HoTen = hoTen;
        }
        public int getScalar(string sql)
        {
            int b;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object a = cmd.ExecuteScalar();
            if (a != DBNull.Value)
            {
                 b = Convert.ToInt32(a);
            }
            else 
                b = 0;
            conn.Close();
            return b;
        }
        public void getNonquery(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getTable(string sql)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter(sql, conn);
            adapt1.Fill(dt);
            conn.Close();
            return dt;
        }
        public int LaySL(int sql)
        {
            int nam = DateTime.Now.Year;
            int a = getScalar("select count(*) from HOADON where MONTH(NGAYLAP) = "+sql+" and YEAR(NGAYLAP) = "+nam+"");
            return a;

        }
        public void BieuDo()
        {
            //chartHoaDon.ChartAreas[0].AxisX.Minimum = 1;
            //chartHoaDon.ChartAreas[0].AxisX.Interval = 1;
            //chartHoaDon.ChartAreas[0].AxisY.Maximum = 12;
            //chartHoaDon.ChartAreas[0].AxisX.Maximum = 300;
            //chartHoaDon.ChartAreas[0].AxisX.Interval = 30;

            chartHoaDon.Series[0].Points.AddXY("Tháng 1", LaySL(1));
            chartHoaDon.Series[0].Points.AddXY("Tháng 2", LaySL(2));
            chartHoaDon.Series[0].Points.AddXY("Tháng 3", LaySL(3));
            chartHoaDon.Series[0].Points.AddXY("Tháng 4", LaySL(4));
            chartHoaDon.Series[0].Points.AddXY("Tháng 5", LaySL(5));
            chartHoaDon.Series[0].Points.AddXY("Tháng 6", LaySL(6));
            chartHoaDon.Series[0].Points.AddXY("Tháng 7", LaySL(7));
            chartHoaDon.Series[0].Points.AddXY("Tháng 8", LaySL(8));
            chartHoaDon.Series[0].Points.AddXY("Tháng 9", LaySL(9));
            chartHoaDon.Series[0].Points.AddXY("Tháng 10", LaySL(10));
            chartHoaDon.Series[0].Points.AddXY("Tháng 11", LaySL(11));
            chartHoaDon.Series[0].Points.AddXY("Tháng 12", LaySL(12));


        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            manv.Text = HoTen;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            string sql = "select sum(THANHTIEN) from HOADON where MONTH(NGAYLAP) = "+thang+" and YEAR(NGAYLAP) = "+nam+"";
            int a = getScalar(sql);
            if (a != 0)
            {
                TienThang.Text = a.ToString("0,000,000") + " VND";
            }
            else
                TienThang.Text = "0" + " VND";
            

            sql = "select count(*) from HOADON where MONTH(NGAYLAP) = " + thang + " and YEAR(NGAYLAP) = " + nam + "";
            int b = getScalar(sql);
            if (b != 0)
            {
                SoLuongDaLap.Text = b.ToString();
            }
            else
                SoLuongDaLap.Text = "0";

            sql = "select sum(THANHTIEN) FROM HOADON, NHANVIEN WHERE HOADON.MANV = NHANVIEN.MANV AND MONTH(NGAYLAP) = " + thang + " and YEAR(NGAYLAP) = " + nam + " AND HOTENNV = N'"+HoTen+"'";
            int c = getScalar(sql);
            if(c!=0)
            {
                label5.Text = c.ToString("0,000,000") + " VND";
            }
            else
            {
                label5.Text = "0";
            }    

            //////////////////////////////////////
            BieuDo();

        }
    }
}
