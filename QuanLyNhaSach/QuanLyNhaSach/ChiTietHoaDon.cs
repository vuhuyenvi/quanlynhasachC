using Microsoft.VisualBasic;
using QuanLyNhaSach.Class;
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

namespace QuanLyNhaSach
{
    public partial class ChiTietHoaDon : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataSet ds;
       
        public ChiTietHoaDon()
        {
            conn = new SqlConnection(KetNoi.trConn);
            adapt = new SqlDataAdapter("select * from HOADON ORDER BY MAHD ASC", conn);
            ds = new DataSet();
            adapt.Fill(ds,"HOADON");
            
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            cboHoaDon.DataSource = ds.Tables["HOADON"];
            cboHoaDon.DisplayMember = "MAHD";
            cboHoaDon.SelectedIndex = 0;
            
        }
        public void Databinding(DataTable dt1)
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dt1, "MAHD");

            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", dt1, "MASACH");

            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dt1, "NGAYLAP");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dt1, "SOLUONG");

            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("Text", dt1, "TENSACH");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dt1, "TONGTIEN");
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapt.SelectCommand = new SqlCommand("select HOADON.MAHD,CHITIETHD.MASACH, TENSACH, NGAYLAP,SOLUONG, TONGTIEN from HOADON,CHITIETHD,SACH where HOADON.MAHD = CHITIETHD.MAHD AND CHITIETHD.MASACH = SACH.MASACH AND CHITIETHD.MAHD = '"+cboHoaDon.Text+"' ORDER BY MAHD ASC", conn);
            adapt.Fill(dt);
            dgvDS.DataSource = dt;
            Databinding(dt);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
