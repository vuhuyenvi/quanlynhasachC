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
using System.Windows.Media;
using TheArtOfDevHtmlRenderer.Adapters;
using QuanLyNhaSach.DAO;
using System.Text.RegularExpressions;

namespace QuanLyNhaSach
{
    public partial class frmThemPhieuNhap : MetroFramework.Forms.MetroForm
    {

        DBConnect db = new DBConnect();
        SqlDataAdapter adapt;
        DataSet ds = new DataSet();
        SqlConnection conn;

        public frmThemPhieuNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
        }



        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if(txtMaPhieuNhap.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng tạo phiếu nhập");
                return;
            }
            if(txtGiaNhap.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập giá nhập cho sản phẩm");
                return;
            }
            if(txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số lượng cho sản phẩm");
                return;
            }
            adapt = new SqlDataAdapter("Select MAPHIEUNHAP,CHITIETPN.MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIANHAP,SOLUONGNHAP from SACH,NHAXUATBAN,THELOAI,TACGIA,CHITIETPN where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and SACH.MASACH=CHITIETPN.MASACH and MAPHIEUNHAP = '"+txtMaPhieuNhap.Text+"' and SACH.MASACH = '" + cboMaSach.SelectedValue.ToString() + "'", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sách đã tồn tại trong phiếu nhập");
                return;
            }
            int tongtien = int.Parse(txtGiaNhap.Text) * int.Parse(txtSoLuong.Text);
            string sql = "INSERT INTO CHITIETPN VALUES('" + cboMaSach.SelectedValue.ToString() + "','" + txtMaPhieuNhap.Text + "','" + int.Parse(txtGiaNhap.Text) + "','" + int.Parse(txtSoLuong.Text) + "','"+tongtien+"')";
            db.getNonQuery(sql);

            tongTienPN();

            sql = "UPDATE SACH SET SOLUONGTON = SOLUONGTON + '" + int.Parse(txtSoLuong.Text) + "' WHERE MASACH = '"+cboMaSach.SelectedValue.ToString()+"'";
            db.getNonQuery(sql);

            MessageBox.Show("Thêm sản phẩm thành công");
            loadDataGridView(txtMaPhieuNhap.Text);
            loadDataGridView();
        }

        public void tongTienPN()
        {
            string sql = "select sum(TONGTIEN) FROM CHITIETPN WHERE MAPHIEUNHAP = '" + txtMaPhieuNhap.Text + "'";
            object result = db.getScalar(sql);
            int thanhtien;
            if (result != null)
            {
                thanhtien = Convert.ToInt32(result);
            }
            else
            {
                thanhtien = 0;
            }
            sql = "UPDATE PHIEUNHAP SET THANHTIEN = '" + thanhtien + "' where MAPHIEUNHAP = '" + txtMaPhieuNhap.Text + "'";
            db.getNonQuery(sql);
            txtThanhTien.Text = thanhtien.ToString();
        }

        public void loadDataGridView(string sql)
        {
            DataTable dt = db.getDataTable("Select MAPHIEUNHAP,CHITIETPN.MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIANHAP,SOLUONGNHAP from SACH,NHAXUATBAN,THELOAI,TACGIA,CHITIETPN where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and SACH.MASACH=CHITIETPN.MASACH");
            DataView dataView = new DataView(dt);
            dataView.RowFilter = "MAPHIEUNHAP = '" + sql + "'";
            dgvSachNhap.DataSource = dataView;
        }

        private void frmThemPhieuNhap_Load(object sender, EventArgs e)
        {
            loadDataGridView(txtMaPhieuNhap.Text);
            //loadDataGridView();
            binding();
            loadCboSACH();
            loadCboNV();
            loadCboNCC();
            
        }

        public void loadCboNCC()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboNhaCungCap.DataSource = dt;
            cboNhaCungCap.ValueMember = "MANCC";
            cboNhaCungCap.DisplayMember = "TENNCC";
        }

        public void loadCboNV()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboNhanVien.DataSource = dt;
            cboNhanVien.ValueMember = "MANV";
            cboNhanVien.DisplayMember = "TENNV";
        }

        public void loadCboSACH()
        {
            string sql = "Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from SACH,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboMaSach.DataSource = dt;
            cboMaSach.ValueMember = "MASACH";
            cboMaSach.DisplayMember = "TENSACH";

            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("text", cboMaSach.DataSource, "TENSACH");
            txtTL.DataBindings.Clear();
            txtTL.DataBindings.Add("text", cboMaSach.DataSource, "TENTL");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("text", cboMaSach.DataSource, "TENNXB");
            txtTG.DataBindings.Clear();
            txtTG.DataBindings.Add("text", cboMaSach.DataSource, "TENTG");
            txtNgayXuatBan.DataBindings.Clear();
            txtNgayXuatBan.DataBindings.Add("Text", cboMaSach.DataSource, "NGAYXUATBAN", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value, "dd-MM-yyyy");

        }

        private void binding()
        {
            cboMaSach.DataBindings.Clear();
            cboMaSach.DataBindings.Add("SelectedValue", dgvSachNhap.DataSource, "MASACH");
            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("text", dgvSachNhap.DataSource, "TENNXB");
            txtTL.DataBindings.Clear();
            txtTL.DataBindings.Add("text", dgvSachNhap.DataSource, "TENTL");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("text", dgvSachNhap.DataSource, "TENSACH");
            txtTG.DataBindings.Clear();
            txtTG.DataBindings.Add("text", dgvSachNhap.DataSource, "TENTG");
            txtNgayXuatBan.DataBindings.Clear();
            txtNgayXuatBan.DataBindings.Add("Text", dgvSachNhap.DataSource, "NGAYXUATBAN", true, DataSourceUpdateMode.OnValidation, null, "dd/MM/yyyy");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("text", dgvSachNhap.DataSource, "GIANHAP");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", dgvSachNhap.DataSource, "SOLUONGNHAP");
        }


        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            DateTime homNay = DateTime.Today;
            string strDay = homNay.ToString("yyyy-MM-dd");
            string sql = "select count(*) from PHIEUNHAP WHERE NGAYNHAP = '" + strDay + "'";
            int stt = (int)db.getScalar(sql);
            stt++;

            string strStt = stt.ToString("000");
            string strMa = "PN" + homNay.ToString("dd") + homNay.ToString("MM") + homNay.ToString("yyyy") + strStt;
            sql = "INSERT INTO PHIEUNHAP VALUES('" + strMa + "', '" + strDay + "',0,'" + cboNhanVien.SelectedValue.ToString() + "','" + cboNhaCungCap.SelectedValue.ToString() + "')";
            db.getNonQuery(sql);
            txtMaPhieuNhap.Text = strMa;

            loadDataGridView();
        }

        public void loadDataGridView()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV", conn);
            DataGridView dgvPhieuNhap = ((XuLyNhapKho)Application.OpenForms["XuLyNhapKho"]).GetDgvPhieuNhap();
            DataSet dsPhieuNhap = new DataSet();
            adapt.Fill(dsPhieuNhap, "PHIEUNHAP");
            dgvPhieuNhap.DataSource = dsPhieuNhap.Tables["PHIEUNHAP"];
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if(dgvSachNhap.SelectedRows == null)
            {
                MessageBox.Show("Vui lòng chọn sách muốn xóa khỏi phiếu");
                return;
            }
            string sql = "DELETE CHITIETPN WHERE MASACH = '"+cboMaSach.SelectedValue.ToString()+"' AND MAPHIEUNHAP = '"+txtMaPhieuNhap.Text+"'";
            db.getNonQuery(sql);
            tongTienPN();
            MessageBox.Show("Xóa thành công");
            loadDataGridView(txtMaPhieuNhap.Text);
            loadDataGridView();
        }

        private void dgvSachNhap_SelectionChanged(object sender, EventArgs e)
        {
            binding();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận hủy phiếu","Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                xoaPN();
                this.Close();
            }
        }

        private void frmThemPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void xoaPN()
        {
            string sql = "DELETE CHITIETPN WHERE MAPHIEUNHAP = '" + txtMaPhieuNhap.Text + "'";
            db.getNonQuery(sql);
            sql = "DELETE PHIEUNHAP WHERE MAPHIEUNHAP = '" + txtMaPhieuNhap.Text + "'";
            db.getNonQuery(sql);
            MessageBox.Show("Hủy thành công");
            loadDataGridView();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Clear();
            txtGiaNhap.Clear();
            txtSoLuong.Clear();
            xoaPN();
            foreach (DataGridViewRow row in dgvSachNhap.Rows)
            {
                dgvSachNhap.Rows.Remove(row);
            }
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if(txtMaPhieuNhap.Text == string.Empty)
            {
                MessageBox.Show("Phiếu nhập chưa được tạo");
                return;
            }
            MessageBox.Show("Lưu thành công");
            this.Close();
        }
    }
}
