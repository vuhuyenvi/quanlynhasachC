using QuanLyNhaSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmSuaPhieuNhap : MetroFramework.Forms.MetroForm
    {
        DBConnect db = new DBConnect();

        public frmSuaPhieuNhap()
        {
            InitializeComponent();
        }

        public void SetValues(string maphieunhap, DateTime ngayNhap, string hotennv, string tenncc, string thanhtien)
        {
            txtMaPhieuNhap.Text = maphieunhap;
            dtpNgayLapPhieu.Text = ngayNhap.ToString();
            txtNhanVien.Text = hotennv;
            cboNCC.Text = tenncc;
            txtThanhTien.Text = thanhtien;
        }

        public void loadDataGridView(string sql)
        {
            DataTable dt = db.getDataTable("Select MAPHIEUNHAP,CHITIETPN.MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIANHAP,SOLUONGNHAP from SACH,NHAXUATBAN,THELOAI,TACGIA,CHITIETPN where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and SACH.MASACH=CHITIETPN.MASACH");
            DataView dataView = new DataView(dt);
            dataView.RowFilter = "MAPHIEUNHAP = '" + sql + "'";
            dgvSachNhap.DataSource = dataView;
        }

        public void loadCboMaSach()
        {
            string sql = "Select SACH.MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIANHAP,SOLUONGNHAP from CHITIETPN, SACH,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG AND SACH.MASACH = CHITIETPN.MASACH";
            DataTable dt = new DataTable();
            dt = db.getDataTable(sql);
            cboMaSach.DataSource = dt;
            cboMaSach.ValueMember = "MASACH";
            cboMaSach.DisplayMember = "TENSACH";

            txtNXB.DataBindings.Clear();
            txtNXB.DataBindings.Add("text", cboMaSach.DataSource, "TENNXB");
            txtTL.DataBindings.Clear();
            txtTL.DataBindings.Add("text", cboMaSach.DataSource, "TENTL");
            txtTenSach.DataBindings.Clear();
            txtTenSach.DataBindings.Add("text", cboMaSach.DataSource, "TENSACH");
            txtTG.DataBindings.Clear();
            txtTG.DataBindings.Add("text", cboMaSach.DataSource, "TENTG");
            txtNgayXuatBan.DataBindings.Clear();
            txtNgayXuatBan.DataBindings.Add("Text", cboMaSach.DataSource, "NGAYXUATBAN", true, DataSourceUpdateMode.OnValidation, null, "dd/MM/yyyy");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("text", cboMaSach.DataSource, "GIANHAP");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", cboMaSach.DataSource, "SOLUONGNHAP");
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

        private void frmSuaPhieuNhap_Load(object sender, EventArgs e)
        {
            loadDataGridView(txtMaPhieuNhap.Text);
            binding();
            loadCboMaSach();
        }
    }
}
