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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaSach
{
    public partial class XuLyNhapKho : Form
    {
        SqlConnection conn;
        DBConnect db =new DBConnect();
        public DataGridViewRow selectedRow;

        public DataSet dsPhieuNhap = new DataSet();

        public XuLyNhapKho()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
        }
        private void XuLyNhapKho_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapt = new SqlDataAdapter("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV", conn);
            adapt.Fill(dsPhieuNhap, "PHIEUNHAP");
            dgvPhieuNhap.DataSource = dsPhieuNhap.Tables["PHIEUNHAP"];

            adapt.SelectCommand = new SqlCommand("Select * from NHAXUATBAN", conn);
            adapt.Fill(dsPhieuNhap, "NHAXUATBAN");
            adapt.SelectCommand = new SqlCommand("Select * from TACGIA", conn);
            adapt.Fill(dsPhieuNhap, "TACGIA");
            adapt.SelectCommand = new SqlCommand("Select * from THELOAI", conn);
            adapt.Fill(dsPhieuNhap, "THELOAI");
            adapt.SelectCommand = new SqlCommand("Select * from NHANVIEN", conn);
            adapt.Fill(dsPhieuNhap, "NHANVIEN");
            adapt.SelectCommand = new SqlCommand("Select * from NHACUNGCAP", conn);
            adapt.Fill(dsPhieuNhap, "NHACUNGCAP");
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThemPhieuNhap themPN = new frmThemPhieuNhap();
            themPN.StartPosition = FormStartPosition.CenterScreen;
            themPN.ShowDialog();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvPhieuNhap.Rows[e.RowIndex];
            }
        }

        public DataSet GetDsPhieuNhap()
        {
            return dsPhieuNhap;
        }

        public DataGridView GetDgvPhieuNhap()
        {
            return dgvPhieuNhap;
        }


        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemPhieuNhap themPN = new frmThemPhieuNhap();
            themPN.StartPosition = FormStartPosition.CenterScreen;
            themPN.ShowDialog();
        }

        public DataTable XemDL(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (cboLocSach.Text == "Mã phiếu nhập")
                dgvPhieuNhap.DataSource = XemDL("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and MAPHIEUNHAP like N'%" + txtTraCuu.Text.Trim() + "%'");
            if (cboLocSach.Text == "Nhân viên nhập")
                dgvPhieuNhap.DataSource = XemDL("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and NHANVIEN.HOTENNV like N'%" + txtTraCuu.Text.Trim() + "%'");
            if (cboLocSach.Text == "Nhà cung cấp")
                dgvPhieuNhap.DataSource = XemDL("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and NHACUNGCAP.TENNCC like N'%" + txtTraCuu.Text.Trim() + "%'");
           
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (cboLocSach.Text == "Mã phiếu nhập")
                dgvPhieuNhap.DataSource = XemDL("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and MAPHIEUNHAP like N'%" + txtTraCuu.Text.Trim() + "%'");
            if (cboLocSach.Text == "Nhân viên nhập")
                dgvPhieuNhap.DataSource = XemDL("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and NHANVIEN.HOTENNV like N'%" + txtTraCuu.Text.Trim() + "%'");
            if (cboLocSach.Text == "Nhà cung cấp")
                dgvPhieuNhap.DataSource = XemDL("Select MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC from PHIEUNHAP,NHACUNGCAP,NHANVIEN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and NHACUNGCAP.TENNCC like N'%" + txtTraCuu.Text.Trim() + "%'");
        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhieuNhap.SelectedRows[0];
                string maPhieuNhap = selectedRow.Cells["MAPHIEUNHAP"].Value.ToString();
                crpPhieuNhap rpt = new crpPhieuNhap();
                frmInPhieuNhap frmIn = new frmInPhieuNhap();
                DataTable dt = db.getDataTable("Select PHIEUNHAP.MAPHIEUNHAP,NGAYNHAP,THANHTIEN,NHANVIEN.HOTENNV,NHACUNGCAP.TENNCC, TENSACH, SOLUONGNHAP, SACH.MASACH, GIANHAP,TONGTIEN,THANHTIEN  from PHIEUNHAP,NHACUNGCAP,NHANVIEN,SACH, CHITIETPN where PHIEUNHAP.MANCC=NHACUNGCAP.MANCC and PHIEUNHAP.MANV=NHANVIEN.MANV and PHIEUNHAP.MAPHIEUNHAP = CHITIETPN.MAPHIEUNHAP AND CHITIETPN.MASACH=SACH.MASACH AND PHIEUNHAP.MAPHIEUNHAP = '" + maPhieuNhap + "'");
                rpt.SetDataSource(dt);
                frmIn.crystalReportViewer1.ReportSource = rpt;
                frmIn.crystalReportViewer1.Refresh();
                frmIn.ShowDialog();
            }
        }
    }
}
