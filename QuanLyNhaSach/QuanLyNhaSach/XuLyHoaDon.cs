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
using QuanLyNhaSach.DAO;
using QuanLyNhaSach.Class;
using System.Text.RegularExpressions;

namespace QuanLyNhaSach
{
    public partial class XuLyHoaDon : Form
    {
        DataSet ds = new DataSet();
        string d;
        DBConnect db = new DBConnect(); 
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[1];


        public XuLyHoaDon()
        {

            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
            adapt = new SqlDataAdapter("select * from HOADON", conn);
            adapt.Fill(Ds, "HOADON");
            adapt.SelectCommand = new SqlCommand("select * from KHACHHANG", conn);
            adapt.Fill(Ds, "KHACHHANG");
            adapt.SelectCommand = new SqlCommand("select * from CHITIETHD", conn);
            adapt.Fill(Ds, "CHITIETHD");
            key[0] = Ds.Tables["HOADON"].Columns[0];

            key1[0] = Ds.Tables["KHACHHANG"].Columns[0];

            //key2[0] = Ds.Tables["CHITIETHD"].Columns[0];

            Ds.Tables["HOADON"].PrimaryKey = key;

            Ds.Tables["KHACHHANG"].PrimaryKey = key1;

            //Ds.Tables["CHITIETHD"].PrimaryKey = key2;
        }

        private void XuLyHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapt.SelectCommand = new SqlCommand("select * from SACH", conn);
            adapt.Fill(dt);
            cboMaSach.DataSource = dt;
            cboMaSach.DisplayMember = "MASACH";

            adapt.SelectCommand = new SqlCommand("select * from NHANVIEN", conn);
            DataTable dt1 = new DataTable();
            adapt.Fill(dt1);
            cboMaNhanVien.DataSource = dt1;
            cboMaNhanVien.DisplayMember = "MANV";

        }

        public void Reset()
        {
            txtSoLuong.Clear();
            cboMaSach.Text = string.Empty;
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtTenSach.Clear();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            HoaDon hd = new HoaDon(cboMaSach.Text, ds);


            //try
            //{
            DialogResult r; r = MessageBox.Show("Bạn có muốn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                int a = Convert.ToInt32(txtTongTien.Text);
                hd.ThemKhachHang(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmailKH.Text);
                d = hd.ThemHoaDon(a, cboMaNhanVien.Text, cboDate.Text);
                hd.ThemChiTietHoaDon(dgvDanhSach, d);
            }
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaSach.ValueMember = "TENSACH";
            txtTenSach.Text = cboMaSach.SelectedValue.ToString();
            cboMaSach.ValueMember = "GIABAN";
            txtDonGia.Text = cboMaSach.SelectedValue.ToString();
        }
        bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if (txtEmailKH.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if (!IsValidEmail(txtEmailKH.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }
            if (txtTenKH.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            HoaDon xuLyHoaDon = new HoaDon(cboMaSach.Text, ds);
            string c = xuLyHoaDon.LayTheLoai();
            string d = xuLyHoaDon.LayTacGia();
            string f = xuLyHoaDon.LayNXB();
            string KhuyenMai = xuLyHoaDon.KTraKhuyenMai(cboDate.Text);
            //try
            //{

                if (cboMaSach.Text == string.Empty)
                {
                    MessageBox.Show("Chưa chọn mã sách");
                }
                else if (KhuyenMai == "0")
                {
                    dgvDanhSach.Rows.Add(cboMaSach.Text, txtTenSach.Text, c, f, d, txtDonGia.Text, txtSoLuong.Text, KhuyenMai, txtThanhTien.Text);
                    string[] a = txtThanhTien.Text.Split(' ');
                    txtTongTien.Text = (int.Parse(txtTongTien.Text) + int.Parse(a[0])).ToString();
                    Reset();
                }
                else
                {
                    string[] a = txtThanhTien.Text.Split(' ');
                    string layKM = (Convert.ToInt32(a[0]) * (1 - float.Parse(KhuyenMai))).ToString();
                    dgvDanhSach.Rows.Add(cboMaSach.Text, txtTenSach.Text, c, f, d, txtDonGia.Text, txtSoLuong.Text, KhuyenMai, layKM);

                    txtTongTien.Text = (Convert.ToInt32(txtTongTien.Text) + Convert.ToInt32(layKM)).ToString();
                    Reset();
                }
            //}
    
            //catch
            //{
            //    MessageBox.Show("Thiếu thông tin");
            //    txtSoLuong.Clear();
            //    txtSoLuong.Focus();
            //}
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            try
            {
                txtThanhTien.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString() + " " + "VND";
            }
            catch
            {
                MessageBox.Show("Nhập thông tin không đúng định dạng");
            }
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaNhanVien.ValueMember = "HOTENNV";
            txtTenNV.Text = cboMaNhanVien.SelectedValue.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1])) this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        public void Reset1()
        {
            Reset();
            cboMaNhanVien.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmailKH.Text = string.Empty;
            dgvDanhSach.Rows.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Reset1();
        }

        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dgvDanhSach.Rows[e.RowIndex];
                cboMaSach.Text = Convert.ToString(row.Cells[0].Value);
                txtTenSach.Text = Convert.ToString(row.Cells[1].Value);
                txtDonGia.Text = Convert.ToString(row.Cells[5].Value);
                txtSoLuong.Text = Convert.ToString(row.Cells[6].Value);
                txtThanhTien.Text = Convert.ToString(row.Cells[7].Value);
            }
            catch
            {
                dgvDanhSach.Focus();
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvDanhSach.SelectedRows)
            {
                dgvDanhSach.Rows.Remove(dr);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon ct = new ChiTietHoaDon();
            ct.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHD = d;
            crpInHoaDon rpt = new crpInHoaDon();
            frmInHoaDon frmIn = new frmInHoaDon();
            DataTable dt = db.getDataTable("Select HOADON.MAHD,NGAYLAP,THANHTIEN,HOTENNV,HOTENKH, TENSACH, CHITIETHD.SOLUONG, SACH.MASACH, CHITIETHD.GIABAN,TONGTIEN,THANHTIEN from HOADON,KHACHHANG,NHANVIEN,SACH, CHITIETHD where HOADON.MAKH=KHACHHANG.MAKH and HOADON.MANV=NHANVIEN.MANV and HOADON.MAHD = CHITIETHD.MAHD AND CHITIETHD.MASACH=SACH.MASACH AND HOADON.MAHD = '" + maHD + "'");
            rpt.SetDataSource(dt);
            frmIn.crystalReportViewer1.ReportSource = rpt;
            frmIn.crystalReportViewer1.Refresh();
            frmIn.ShowDialog();
        }
    }
}
