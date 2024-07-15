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

namespace QLNhanVIen
{
    public partial class FormQuanLyNhanVien : Form
    {
        DBConnect db = new DBConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter adapt;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            string sql = "SELECT MANV, TENCV, HOTENNV, DIACHINV, SODT, EMAILNV FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV";
            DataTable dt = db.getDataTable(sql);
            dgvNhanVien.DataSource = dt;

            binding();
            loadCboChucVu();
            
        }

        public void loadCboChucVu()
        {
            string sql = "SELECT * FROM CHUCVU";
            DataTable dt = db.getDataTable(sql);
            cboChucVu.DataSource = dt;
            cboChucVu.ValueMember = "TENCV";
            cboChucVu.DisplayMember = "TENCV";
        }

        public void binding()
        {
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("text", dgvNhanVien.DataSource, "HOTENNV");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", dgvNhanVien.DataSource, "EMAILNV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dgvNhanVien.DataSource, "DIACHINV");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("text", dgvNhanVien.DataSource, "MANV");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", dgvNhanVien.DataSource, "SODT");
            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("SelectedValue", dgvNhanVien.DataSource, "TENCV");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = txtEmail.Enabled = txtHoVaTen.Enabled = txtMaNV.Enabled = txtSDT.Enabled = true;
            cboChucVu.Enabled = true;
            string sql = "SELECT COUNT(*) FROM NHANVIEN";
            int stt = (int)db.getScalar(sql);
            string StrStt = stt.ToString();
            string maNV = "NV" + StrStt;
            txtMaNV.Text = maNV;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = txtEmail.Enabled = txtHoVaTen.Enabled = txtSDT.Enabled = true;
            cboChucVu.Enabled = true;
            txtMaNV.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                return;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập Email!");
                return;
            }
            if (txtHoVaTen.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên!");
                return;
            }
            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                return;
            }

            if(txtMaNV.Enabled == true)
            {
                string sql = "SELECT * FROM NHANVIEN WHERE MANV ='" + txtMaNV.Text + "'";
                DataTable dt = db.getDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                    return;
                }
                
                cboChucVu.ValueMember = "MACV";
                sql = "INSERT INTO NHANVIEN VALUES('" + txtMaNV.Text + "','" + cboChucVu.SelectedValue.ToString() + "',N'" + txtHoVaTen.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtEmail.Text + "')";
                db.getNonQuery(sql);
                sql = "SELECT MANV, TENCV, HOTENNV, DIACHINV, SODT, EMAILNV FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV";
                dt = db.getDataTable(sql);
                dgvNhanVien.DataSource = dt;
                MessageBox.Show("Thêm nhân viên thành công");
                txtDiaChi.Enabled = txtEmail.Enabled = txtHoVaTen.Enabled = txtMaNV.Enabled = txtSDT.Enabled = cboChucVu.Enabled = false;
            }
            else
            {
                cboChucVu.ValueMember = "MACV";
                string sql = "UPDATE NHANVIEN SET HOTENNV = N'" + txtHoVaTen.Text + "', MACV = '" + cboChucVu.SelectedValue.ToString() + "',DIACHINV = N'" + txtDiaChi.Text + "', SODT = '" + txtSDT.Text + "', EMAILNV = '" + txtEmail.Text + "'";
                db.getNonQuery(sql);
                sql = "SELECT MANV, TENCV, HOTENNV, DIACHINV, SODT, EMAILNV FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV";
                DataTable dt = db.getDataTable(sql);
                dgvNhanVien.DataSource = dt;
                MessageBox.Show("Sửa nhân viên thành công");
                txtDiaChi.Enabled = txtEmail.Enabled = txtHoVaTen.Enabled = txtMaNV.Enabled = txtSDT.Enabled = cboChucVu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "select * from TAIKHOAN WHERE MANV = '" + txtMaNV.Text + "'";
            string sql1 = "select * from HOADON WHERE MANV = '" + txtMaNV.Text + "'";
            DataTable dt = db.getDataTable(sql);
            DataTable dt1 = db.getDataTable(sql1);
            if (dt.Rows.Count > 0 || dt1.Rows.Count > 0)
            {
                MessageBox.Show("Dữ liệu đang được sử dụng không thể xóa");
                return;
            }
            sql = "delete NHANVIEN where MANV = '" + txtMaNV.Text + "'";
            db.getNonQuery(sql);
            sql = "SELECT MANV, TENCV, HOTENNV, DIACHINV, SODT, EMAILNV FROM NHANVIEN, CHUCVU WHERE NHANVIEN.MACV = CHUCVU.MACV";
            dt = db.getDataTable(sql);
            dgvNhanVien.DataSource = dt;
            MessageBox.Show("Xóa nhân viên thành công");
            txtDiaChi.Enabled = txtEmail.Enabled = txtHoVaTen.Enabled = txtMaNV.Enabled = txtSDT.Enabled = cboChucVu.Enabled = false;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            binding();
            loadCboChucVu();
        }
    }
}
