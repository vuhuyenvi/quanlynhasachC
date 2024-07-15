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
using QuanLyNhaSach.QLKH;
using QuanLyNhaSach;
using QuanLyNhaSach.Class;

namespace QuanLyNhaSach
{
    public partial class QuanLyKhachHang : Form
    {
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataColumn[] key = new DataColumn[1];
        KhachHangBUS kh = new KhachHangBUS();

        public QuanLyKhachHang()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
            adapt = new SqlDataAdapter("select * from KHACHHANG", conn);
            adapt.Fill(ds, "KHACHHANG");
            //key[0] = ds.Tables["KHACHHANG"].Columns[0];
            //ds.Tables["KHACHHANG"].PrimaryKey = key;
        }

        public void Databinding(DataTable dt)
        {
            cboMaKH.DataBindings.Clear();
            cboMaKH.DataBindings.Add("Text", dt, "MAKH");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dt, "HOTENKH");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dt, "DIACHIKH");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dt, "SODT");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dt, "EMAILKH");
        }

        public void cbo()
        {
            cboMaKH.DataSource = ds.Tables["KHACHHANG"];
            cboMaKH.DisplayMember = "MAKH";
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvDS.DataSource = ds.Tables["KHACHHANG"];
            cbo();
            Databinding(ds.Tables["KHACHHANG"]);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh1 = new KhachHangDTO(cboMaKH.Text, txtHoTen.Text, txtEmail.Text, txtDiaChi.Text, txtSDT.Text);
            bool kq = kh.Update(kh1);
            if (kq == true)
            {
                MessageBox.Show("Sửa Thành Công");
                dgvDS.DataSource = ds.Tables[0];
            }
            else
                MessageBox.Show("Sửa Thất Bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh1 = new KhachHangDTO(cboMaKH.Text, txtHoTen.Text, txtEmail.Text, txtDiaChi.Text, txtSDT.Text);
            bool kq = kh.delete(kh1);
            if (kq == true)
            {
                MessageBox.Show("Xóa Thành Công");
                ds = new DataSet();
                adapt.Fill(ds, "KHACHHANG");
                dgvDS.DataSource = ds.Tables[0];
                Databinding(ds.Tables["KHACHHANG"]);
            }
            else
                MessageBox.Show("Dữ liệu đang được sử dụng nên không thể xóa");
        }
    }
}
