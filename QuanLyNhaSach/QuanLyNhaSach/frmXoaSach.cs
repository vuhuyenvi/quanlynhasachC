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

namespace QuanLyNhaSach
{
    public partial class frmXoaSach : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adapt;
        public frmXoaSach()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
        }

        public frmXoaSach(string masach, string tennxb, string tentl, string tensach, string tentg, string ngayxuatban, string giaban, string soluongton)
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.trConn);
            txtMasach.Text = masach;
            txtTennxb.Text = tennxb;
            txtTentl.Text = tentl;
            txtTensach.Text = tensach;
            txtTentg.Text = tentg;
            txtNgayxuatban.Text = ngayxuatban;
            txtGiaban.Text = giaban;
            txtSoluongton.Text = soluongton;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("Select * from Sach",conn);
            adapt.Fill(ds, "Sach");
            DataRow delete_row = ds.Tables["Sach"].Rows.Find(txtMasach.Text);
            if (delete_row != null)
            {
                delete_row["SOLUONGTON"] = 0;
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapt);
                adapt.Update(ds, "Sach");
                MessageBox.Show("Xóa thành công");
            }
            
            DataGridView dgvSach = ((QuanLySach)Application.OpenForms["QuanLySach"]).GetDgvSach();
            string sql = "Select MASACH,TENNXB,TENTL,TENSACH,TENTG,NGAYXUATBAN,GIABAN,SOLUONGTON from SACH,NHAXUATBAN,THELOAI,TACGIA where SACH.MANXB=NHAXUATBAN.MANXB and SACH.MATL=THELOAI.MATL and SACH.MATG=TACGIA.MATG ORDER BY CAST(SUBSTRING(MASACH, 2, LEN(MASACH) - 1) AS INT)";
            adapt = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvSach.DataSource = dt;
            this.Close();
        }

        private void frmXoaSach_Load(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("select * from Sach", conn);
            adapt.Fill(ds, "Sach");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Sach"].Columns[0];
            ds.Tables["Sach"].PrimaryKey = key;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
