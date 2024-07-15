using QuanLyNhaSach.Class;
using QuanLyNhaSach.DAO;
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
    public partial class QuanLyTaiKhoan : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapt;
        public DataSet dsTaiKhoan = new DataSet();
        DBConnect db = new DBConnect();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("Select TENDN, TENHT,MATKHAU,PHANQUYEN,TAIKHOAN.MANV,HOTENNV,EMAILNV from TAIKHOAN,NHANVIEN where TAIKHOAN.MANV=NHANVIEN.MANV", conn);
            adapt.Fill(dsTaiKhoan, "TAIKHOAN");
            dgvTaiKhoan.DataSource = dsTaiKhoan.Tables["TAIKHOAN"];

            adapt.SelectCommand = new SqlCommand("select* from TAIKHOAN", conn);
            adapt.Fill(dsTaiKhoan, "TAIKHOAN1");

            DataColumn[] key = new DataColumn[1];
            key[0] = dsTaiKhoan.Tables["TAIKHOAN"].Columns[0];
            dsTaiKhoan.Tables["TAIKHOAN"].PrimaryKey = key;

            DataColumn[] key1 = new DataColumn[1];
            key1[0] = dsTaiKhoan.Tables["TAIKHOAN1"].Columns[0];
            dsTaiKhoan.Tables["TAIKHOAN1"].PrimaryKey = key1;

            adapt.SelectCommand = new SqlCommand("select * from NHANVIEN", conn);
            adapt.Fill(dsTaiKhoan, "MA");

            cboMaNV.DataSource = dsTaiKhoan.Tables["MA"];
            cboMaNV.DisplayMember = "MANV";
            cboMaNV.ValueMember = "MANV";

            //cboPhanQuyen.DataSource = dsTaiKhoan.Tables["TAIKHOAN"];
            //cboPhanQuyen.DisplayMember = "PHANQUYEN";
            //cboPhanQuyen.ValueMember = "PHANQUYEN";
            bingding();
            //cboMaNV.SelectedIndexChanged += new EventHandler(cboMaNV_SelectedIndexChanged);
            List<string> danhSachPhanQuyen = new List<string> { "Admin", "User" };
            cboPhanQuyen.DataSource = danhSachPhanQuyen;
            cboMaNV.SelectedIndex = 0;

            txtEmail.Enabled = txtTenNV.Enabled = false;
            cboPhanQuyen.Enabled = cboMaNV.Enabled = txtMatKhau.Enabled = txtTenHienThi.Enabled = false;

        }
        public void loadCboPhanQuyen(string manv)
        {
            
            string sql = "select PHANQUYEN FROM TAIKHOAN where MANV = '"+manv+"'";
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(sql, conn);
            adapt.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                string phanQuyen = db.getScalar(sql).ToString();
                if (phanQuyen == "Admin")
                    cboPhanQuyen.Text = "Admin";
                else
                    cboPhanQuyen.Text = "User";
            }
            
        }
        private void bingding()
        {
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", cboMaNV.DataSource, "EMAILNV");
            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("SelectedValue", dgvTaiKhoan.DataSource, "MANV");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("text", dgvTaiKhoan.DataSource, "MATKHAU");
            txtTenHienThi.DataBindings.Clear();
            txtTenHienThi.DataBindings.Add("text", dgvTaiKhoan.DataSource, "TENHT");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("text", cboMaNV.DataSource, "HOTENNV");
            //cboPhanQuyen.DataBindings.Clear();
            //cboPhanQuyen.DataBindings.Add("SelectedValue", dgvTaiKhoan.DataSource, "PHANQUYEN");
        }

        private void dgvThongTin_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) 
            {
                e.CellStyle.BackColor = Color.LightBlue;
                e.PaintBackground(e.CellBounds, true);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMaNV.Enabled = cboPhanQuyen.Enabled = true;
            txtTenHienThi.Enabled = true;
            txtMatKhau.Enabled = true;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cboMaNV.Enabled == true)
            {
                SqlDataAdapter adapt = new SqlDataAdapter("Select * from TAIKHOAN", conn);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapt);

                adapt.Fill(dsTaiKhoan, "TAIKHOAN1");

                DataRow themTK = dsTaiKhoan.Tables["TAIKHOAN1"].NewRow();
                string sql = "Select * from TAIKHOAN where MANV = '" + cboMaNV.SelectedValue.ToString() + "'";
                DataTable dt = db.getDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Nhân viên đã có tài khoản");
                    return;
                }
                themTK["TENDN"] = txtTenHienThi.Text;
                themTK["TENHT"] = txtTenHienThi.Text;
                themTK["MATKHAU"] = txtMatKhau.Text;
                themTK["PHANQUYEN"] = cboPhanQuyen.SelectedValue.ToString();
                themTK["MANV"] = cboMaNV.SelectedValue.ToString();

                dsTaiKhoan.Tables["TAIKHOAN1"].Rows.Add(themTK);

                adapt.Update(dsTaiKhoan, "TAIKHOAN1");



                adapt = new SqlDataAdapter("Select TENDN, TENHT,MATKHAU,PHANQUYEN,TAIKHOAN.MANV,HOTENNV,EMAILNV from TAIKHOAN,NHANVIEN where TAIKHOAN.MANV=NHANVIEN.MANV", conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapt);
                adapt.Fill(dsTaiKhoan, "TAIKHOAN");
                dgvTaiKhoan.DataSource = dsTaiKhoan.Tables["TAIKHOAN"];
                MessageBox.Show("Thêm thanh cong");
                txtTenHienThi.Enabled = txtMatKhau.Enabled = false;
            }    
            else
            {
                adapt = new SqlDataAdapter("Select * from TAIKHOAN", conn);
                adapt.Fill(dsTaiKhoan, "TAIKHOAN1");
                string sql = "select TENDN from TAIKHOAN where MANV = '" + cboMaNV.SelectedValue.ToString() + "'";
                string manv = db.getScalar(sql).ToString();
                DataRow suaTK = dsTaiKhoan.Tables["TAIKHOAN1"].Rows.Find(manv);
                if (suaTK != null)
                {
                    suaTK["TENHT"] = txtTenHienThi.Text;
                    suaTK["MATKHAU"] = txtMatKhau.Text;
                    suaTK["PHANQUYEN"] = cboPhanQuyen.SelectedValue.ToString();
                    suaTK["MANV"] = cboMaNV.Text;
                }
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapt);
                adapt.Update(dsTaiKhoan, "TAIKHOAN1");
                MessageBox.Show("Cập nhật thành công");
                adapt = new SqlDataAdapter("Select TENDN,TENHT, MATKHAU,PHANQUYEN,TAIKHOAN.MANV,HOTENNV,EMAILNV from TAIKHOAN,NHANVIEN where TAIKHOAN.MANV=NHANVIEN.MANV", conn);
                adapt.Fill(dsTaiKhoan, "TAIKHOAN");
                dgvTaiKhoan.DataSource = dsTaiKhoan.Tables["TAIKHOAN"];
            }    
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenHienThi.Clear();
            txtMatKhau.Clear();
            cboMaNV.Enabled = false;
            cboPhanQuyen.Enabled = true;
            txtTenHienThi.Enabled = txtMatKhau.Enabled = true;
        }

        private void cboPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {

            if (cboMaNV.SelectedValue != null)
            {
                loadCboPhanQuyen(cboMaNV.SelectedValue.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                adapt = new SqlDataAdapter("Select * from TAIKHOAN", conn);
                adapt.Fill(dsTaiKhoan, "TAIKHOAN1");
                string sql = "select TENDN from TAIKHOAN where MANV = '" + cboMaNV.SelectedValue.ToString() + "'";
                string manv = db.getScalar(sql).ToString();
                DataRow delete_row = dsTaiKhoan.Tables["TAIKHOAN1"].Rows.Find(manv);
                if (delete_row != null)
                {
                    delete_row.Delete();
                }
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapt);
                adapt.Update(dsTaiKhoan, "TAIKHOAN1");
                MessageBox.Show("Xóa thành công");
                sql = "Select TENDN,TENHT, MATKHAU,PHANQUYEN,TAIKHOAN.MANV,HOTENNV,EMAILNV from TAIKHOAN,NHANVIEN where TAIKHOAN.MANV=NHANVIEN.MANV";
                //adapt = new SqlDataAdapter("Select TENDN,TENHT, MATKHAU,PHANQUYEN,TAIKHOAN.MANV,HOTENNV,EMAILNV from TAIKHOAN,NHANVIEN where TAIKHOAN.MANV=NHANVIEN.MANV", conn);
                //adapt.Fill(dsTaiKhoan, "TAIKHOAN");
                //dgvTaiKhoan.DataSource = dsTaiKhoan.Tables["TAIKHOAN"];
                DataTable dt = new DataTable();
                dt = db.getDataTable(sql);
                dgvTaiKhoan.DataSource = dt;
            }
        }
        public DataTable XemDL(string loc)
        {
            SqlDataAdapter adap = new SqlDataAdapter(loc, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if(txtTraCuu.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập dữ liệu tra cứu");
            }
            else
            {
                if (cboTimTK.Text == "Tên nhân viên")
                    dgvTaiKhoan.DataSource = XemDL("Select NHANVIEN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN from NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and HOTENNV like N'%" + txtTraCuu.Text.Trim() + "%' ");
                if (cboTimTK.Text == "Mã nhân viên")
                    dgvTaiKhoan.DataSource = XemDL("Select TAIKHOAN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN from  NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and TAIKHOAN.MANV like N'%" + txtTraCuu.Text.Trim() + "%' ");
                if (cboTimTK.Text == "Tên đăng nhập")
                    dgvTaiKhoan.DataSource = XemDL("Select TAIKHOAN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN  from  NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and TENDN like N'%" + txtTraCuu.Text.Trim() + "%' ");
                if (cboTimTK.Text == "Email")
                    dgvTaiKhoan.DataSource = XemDL("Select TAIKHOAN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN  from  NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and EMAILNV like N'%" + txtTraCuu.Text.Trim() + "%' ");
            }

        }
        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (cboTimTK.Text == "Tên nhân viên")
                dgvTaiKhoan.DataSource = XemDL("Select NHANVIEN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN from NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and HOTENNV like N'%" + txtTraCuu.Text.Trim() + "%' ");
            if (cboTimTK.Text == "Mã nhân viên")
                dgvTaiKhoan.DataSource = XemDL("Select TAIKHOAN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN from  NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and TAIKHOAN.MANV like N'%" + txtTraCuu.Text.Trim() + "%' ");
            if (cboTimTK.Text == "Tên đăng nhập")
                dgvTaiKhoan.DataSource = XemDL("Select TAIKHOAN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN  from  NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and TENDN like N'%" + txtTraCuu.Text.Trim() + "%' ");
            if (cboTimTK.Text == "Email")
                dgvTaiKhoan.DataSource = XemDL("Select TAIKHOAN.MANV, TENDN, TENHT, MATKHAU, HOTENNV, EMAILNV, PHANQUYEN  from  NHANVIEN, TAIKHOAN where TAIKHOAN.MANV = NHANVIEN.MANV and EMAILNV like N'%" + txtTraCuu.Text.Trim() + "%' ");
        }
    }
}
