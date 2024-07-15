using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach
{
    public partial class frmThemSach : MetroFramework.Forms.MetroForm
    {
        DBConnect db = new DBConnect();
        SqlDataAdapter adapt;
        DataSet ds = new DataSet();

        public frmThemSach()
        {
            InitializeComponent();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            loadCboNXB();
            loadCboTL();
            loadCboTG();
            string sql = "Select count(*) from SACH";
            int stt = (int)db.getScalar(sql);
            stt++;
            string maSach = "S" + stt.ToString();
            txtMaSach.Text = maSach;
        }

        public void loadCboNXB()
        {
            string sql = "SELECT * FROM NHAXUATBAN";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboNXB.DataSource = dt;
            cboNXB.ValueMember = "MANXB";
            cboNXB.DisplayMember = "TENNXB";
        }

        public void loadCboTL()
        {
            string sql = "SELECT * FROM THELOAI";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboTheLoai.DataSource = dt;
            cboTheLoai.ValueMember = "MATL";
            cboTheLoai.DisplayMember = "TENTL";
        }

        public void loadCboTG()
        {
            string sql = "SELECT * FROM TACGIA";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboTacGia.DataSource = dt;
            cboTacGia.ValueMember = "MATG";
            cboTacGia.DisplayMember = "TENTG";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtNgayXuatBan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập ngày xuất bản");
                return;
            }
            string ngayXuatBanStr = txtNgayXuatBan.Text;
            string dinhDangNgay = "dd/MM/yyyy";

            if (!DateTime.TryParseExact(ngayXuatBanStr, dinhDangNgay, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayXuatBan))
            {
                MessageBox.Show("Ngày xuất bản không đúng định dạng. Vui lòng nhập theo định dạng dd/MM/yyyy");
                return;
            }

            // So sánh ngày nhập với ngày hiện tại
            if (ngayXuatBan > DateTime.Now)
            {
                MessageBox.Show("Ngày xuất bản không thể lớn hơn ngày hiện tại");
                return;
            }
            if (txtTenSach.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên sách");
                return;
            }
            if (txtGiaBan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập giá bán");
                return;
            }
            if (!double.TryParse(txtGiaBan.Text, out double giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán phải là số lớn hơn 0");
                return;
            }
            string sql = "Select count(*) from SACH";
            int stt = (int)db.getScalar(sql);
            stt++;
            string maSach = "S" + stt.ToString();
            //string ngayXB = txtNgayXuatBan.ToString("yyyy-MM-dd");
            sql = "INSERT INTO SACH VALUES('" + maSach + "','" + cboNXB.SelectedValue.ToString() + "','" + cboTheLoai.SelectedValue.ToString() + "','" + txtTenSach.Text + "','" + cboTacGia.SelectedValue.ToString() + "','" + txtNgayXuatBan.Text + "','" + txtGiaBan.Text + "',0)";
            db.getNonQuery(sql);
            MessageBox.Show("Thêm sách thành công");
            DataGridView dgvSach = ((QuanLySach)Application.OpenForms["QuanLySach"]).GetDgvSach();
            sql = "Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from SACH,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)";
            DataTable dt = db.getDataTable(sql);
            dgvSach.DataSource = dt;
            this.Close();
        }

        
    }
}
