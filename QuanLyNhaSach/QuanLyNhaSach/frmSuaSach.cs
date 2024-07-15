using QuanLyNhaSach.Class;
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
using System.Windows.Media;

namespace QuanLyNhaSach
{
    public partial class frmSuaSach : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adapt;
        public frmSuaSach()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
        }

        private string maSach;
        private string tenSach;
        private DateTime ngayXuatBan;
        private string tenNXB;
        private string tenTG;
        private string tenTL;
        private string giaBan;
        private string soLuongTon;

        public frmSuaSach(string masach, string tennxb, string tentl, string tensach, string tentg, DateTime ngayxuatban, string giaban, string soluongton)
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
            this.maSach = masach;
            this.tenTG = tentg;
            this.tenTL = tentl;
            this.tenSach = tensach;
            this.ngayXuatBan = ngayxuatban;
            this.tenNXB = tennxb;
            this.giaBan = giaban;
            this.soLuongTon = soluongton;
        }

        private void frmSuaSach_Load(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("select * from Sach", conn);
            adapt.Fill(ds, "Sach");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Sach"].Columns[0];
            ds.Tables["Sach"].PrimaryKey = key;

            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtNgayXuatBan.Text = ngayXuatBan.ToString("dd/MM/yyyy");
            txtSoLuong.Text = soLuongTon;
            txtGiaBan.Text = giaBan;


            adapt.SelectCommand = new SqlCommand("Select * from NHAXUATBAN", conn);
            adapt.Fill(ds, "NHAXUATBAN");
            cboNXB.DataSource = ds.Tables["NHAXUATBAN"];
            cboNXB.DisplayMember = "TENNXB";
            cboNXB.ValueMember = "MANXB";

            adapt.SelectCommand = new SqlCommand("Select * from TACGIA", conn);
            adapt.Fill(ds, "TACGIA");
            cboTacGia.DataSource = ds.Tables["TACGIA"];
            cboTacGia.DisplayMember = "TENTG";
            cboTacGia.ValueMember = "MATG";

            adapt.SelectCommand = new SqlCommand("Select * from THELOAI", conn);
            adapt.Fill(ds, "THELOAI");
            cboTheLoai.DataSource = ds.Tables["THELOAI"];
            cboTheLoai.DisplayMember = "TENTL";
            cboTheLoai.ValueMember = "MATL";

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("Select * from Sach", conn);
            adapt.Fill(ds, "Sach");
            DataRow upRow = ds.Tables["Sach"].Rows.Find(txtMaSach.Text);
            if (upRow != null)
            {
                upRow["MASACH"] = txtMaSach.Text;
                upRow["TENSACH"] = txtTenSach.Text;
                DateTime ngayXuatBan;
                if (DateTime.TryParseExact(txtNgayXuatBan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayXuatBan))
                {
                    upRow["NGAYXUATBAN"] = ngayXuatBan;
                }
                upRow["MANXB"] = cboNXB.SelectedValue.ToString();
                upRow["MATG"] = cboTacGia.SelectedValue.ToString();
                upRow["MATL"] = cboTheLoai.SelectedValue.ToString();
                upRow["GIABAN"] = txtGiaBan.Text;
                upRow["SOLUONGTON"] = txtSoLuong.Text;
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapt);
                adapt.Update(ds, "Sach");
                MessageBox.Show("Cập nhật thành công");
            }

            DataGridView dgvSach = ((QuanLySach)Application.OpenForms["QuanLySach"]).GetDgvSach();
            string sql = "Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from SACH,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)";
            adapt = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvSach.DataSource = dt;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
