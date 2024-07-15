using QuanLyNhaSach.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Media;

namespace QuanLyNhaSach
{
    public partial class QuanLySach : Form
    {
        public DataGridViewRow selectedRow;

        SqlConnection conn;

        public DataSet dsSach = new DataSet();

        SqlDataAdapter adapt;

        public QuanLySach()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
        }
        private string sql = "Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from SACH,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)";
        private void QuanLySach_Load(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter(sql, conn);
            adapt.Fill(dsSach, "SACH");
            dgvSach.DataSource = dsSach.Tables["SACH"];

            DataColumn[] col = new DataColumn[1];
            col[0] = dsSach.Tables["SACH"].Columns[0];
            dsSach.Tables["SACH"].PrimaryKey = col;

            cboLocSach.Text = "Tên sách";

            adapt.SelectCommand = new SqlCommand("Select * from NHAXUATBAN", conn);
            adapt.Fill(dsSach, "NHAXUATBAN");
            adapt.SelectCommand = new SqlCommand("Select * from TACGIA", conn);
            adapt.Fill(dsSach, "TACGIA");
            adapt.SelectCommand = new SqlCommand("Select * from THELOAI", conn);
            adapt.Fill(dsSach, "THELOAI");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                string masach = selectedRow.Cells["MASACH"].Value.ToString();
                string tennxb = selectedRow.Cells["TENNXB"].Value.ToString();
                string tentl = selectedRow.Cells["TENTL"].Value.ToString();
                string tensach = selectedRow.Cells["TENSACH"].Value.ToString();
                string tentg = selectedRow.Cells["TENTG"].Value.ToString();
                string ngayXuatBanStr = selectedRow.Cells["NGAYXUATBAN"].Value.ToString();
                DateTime ngayXuatBan = DateTime.TryParse(ngayXuatBanStr, out ngayXuatBan) ? ngayXuatBan : DateTime.MinValue;
                string giaban = selectedRow.Cells["GIABAN"].Value.ToString();
                string soluongton = selectedRow.Cells["SOLUONGTON"].Value.ToString();

                frmSuaSach suaSach = new frmSuaSach(masach,tennxb, tentl,tensach, tentg, ngayXuatBan, giaban, soluongton);
                suaSach.StartPosition = FormStartPosition.CenterScreen;

                suaSach.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                string masach = selectedRow.Cells["MASACH"].Value.ToString();
                string tennxb = selectedRow.Cells["TENNXB"].Value.ToString();
                string tentl = selectedRow.Cells["TENTL"].Value.ToString();
                string tensach = selectedRow.Cells["TENSACH"].Value.ToString();
                string tentg = selectedRow.Cells["TENTG"].Value.ToString();
                string ngayXuatBanStr = selectedRow.Cells["NGAYXUATBAN"].Value.ToString();
                string giaban = selectedRow.Cells["GIABAN"].Value.ToString();
                string soluongton = selectedRow.Cells["SOLUONGTON"].Value.ToString();

                frmXoaSach xoaSach = new frmXoaSach(masach, tennxb, tentl, tensach, tentg, ngayXuatBanStr, giaban, soluongton);
                xoaSach.StartPosition = FormStartPosition.CenterScreen;
                xoaSach.ShowDialog();
            }
        }

        

        public DataTable XemDL(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if(cboLocSach.Text == "Tên sách")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENSACH like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
            if(cboLocSach.Text == "Nhà xuất bản")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENNXB like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
            if(cboLocSach.Text == "Thể loại")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENTL like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
            if (cboLocSach.Text == "Tác giả")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENTG like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
        }

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (cboLocSach.Text == "Tên sách")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENSACH like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
            if (cboLocSach.Text == "Nhà xuất bản")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENNXB like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
            if (cboLocSach.Text == "Thể loại")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENTL like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
            if (cboLocSach.Text == "Tác giả")
                dgvSach.DataSource = XemDL("Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from Sach,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG and TENTG like N'%" + txtTraCuu.Text.Trim() + "%' ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)");
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvSach.Rows[e.RowIndex];
            }
        }

        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedRow != null)
            {
                string masach = selectedRow.Cells["MASACH"].Value.ToString();
                string tennxb = selectedRow.Cells["TENNXB"].Value.ToString();
                string tentl = selectedRow.Cells["TENTL"].Value.ToString();
                string tensach = selectedRow.Cells["TENSACH"].Value.ToString();
                string tentg = selectedRow.Cells["TENTG"].Value.ToString();
                string ngayXuatBanStr = selectedRow.Cells["NGAYXUATBAN"].Value.ToString();

                DateTime ngayXuatBan = DateTime.TryParse(ngayXuatBanStr, out ngayXuatBan) ? ngayXuatBan : DateTime.MinValue;
                string giaban = selectedRow.Cells["GIABAN"].Value.ToString();
                string soluongton = selectedRow.Cells["SOLUONGTON"].Value.ToString();

                frmSuaSach suaSach = new frmSuaSach(masach, tennxb, tentl, tensach, tentg, ngayXuatBan, giaban, soluongton);
                suaSach.StartPosition = FormStartPosition.CenterScreen;

                suaSach.ShowDialog();
            }
        }


        public DataGridView GetDgvSach()
        {
            return dgvSach;
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {

        }

        public DataAdapter GetDataAdapter()
        {
            return adapt;
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemSach frmThemSach = new frmThemSach();
            frmThemSach.StartPosition = FormStartPosition.CenterScreen;
            frmThemSach.ShowDialog();
            
        }
    }
}
