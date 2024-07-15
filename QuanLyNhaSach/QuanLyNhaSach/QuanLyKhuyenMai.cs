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
using QuanLyNhaSach.Class;

namespace QuanLyNhaSach
{
    public partial class QuanLyKhuyenMai : Form
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter adapt;
        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[1];
        public void Refresh1()
        {
            adapt = new SqlDataAdapter("select * from KHUYENMAI", conn);
            ds = new DataSet();
            adapt.Fill(ds, "KHUYENMAI");
            adapt.SelectCommand = new SqlCommand("select * from SACHKHUYENMAI", conn);
            adapt.Fill(ds, "SACHKHUYENMAI");
            key[0] = ds.Tables["KHUYENMAI"].Columns[0];

            key1[0] = ds.Tables["SACHKHUYENMAI"].Columns[0];
            ds.Tables["KHUYENMAI"].PrimaryKey = key;
            ds.Tables["SACHKHUYENMAI"].PrimaryKey = key1;
        }
        public QuanLyKhuyenMai()
        {
            conn = new SqlConnection(KetNoi.trConn);
            Refresh1();
            InitializeComponent();
        }

        private void drvDanhSachKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int getScalar(string sql)
        {
            int b;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object a = cmd.ExecuteScalar();
            if (a != DBNull.Value)
            {
                b = Convert.ToInt32(a);
            }
            else
                b = 0;
            conn.Close();
            return b;
        }
        public void getNonquery(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getTable(string sql)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter(sql, conn);
            adapt1.Fill(dt);
            conn.Close();
            return dt;
        }
        public void Databinding(DataTable dt, DataTable dt1)
        {
            cboMaSachKM.DataBindings.Clear();
            cboMaSachKM.DataBindings.Add("SelectedValue", dt1, "MAKM");

            cboMaSach.DataBindings.Clear();
            cboMaSach.DataBindings.Add("SelectedValue", dt1, "MASACH");

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dt1, "ID");

            ///////////
            txtMaKM.DataBindings.Clear();
            txtMaKM.DataBindings.Add("Text", dt, "MAKM");

            txtGiamGia.DataBindings.Clear();
            txtGiamGia.DataBindings.Add("Text", dt, "GIAMGIA");

            mskBD.DataBindings.Clear();
            mskBD.DataBindings.Add("Text", dt, "NGAYBD", true, DataSourceUpdateMode.OnPropertyChanged,DBNull.Value,"MM-dd-yyyy");

            mskKT.DataBindings.Clear();
            mskKT.DataBindings.Add("Text", dt, "NGAYKT", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value, "MM-dd-yyyy");

        }
        public void cbo()
        {
            DataTable dt = new DataTable();
            adapt.SelectCommand = new SqlCommand("select * from SACH ",conn);
            adapt.Fill(dt);
            cboMaSach.DataSource = dt;
            cboMaSach.DisplayMember = "TENSACH";
            cboMaSach.ValueMember = "MASACH";

            cboMaSachKM.DataSource = ds.Tables["KHUYENMAI"];
            cboMaSachKM.DisplayMember = "MAKM";
            cboMaSachKM.ValueMember = "MAKM";

            //dgvKhuyenMai
        }

        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.DataSource = ds.Tables["KHUYENMAI"];
            dgvSachKM.DataSource = ds.Tables["SACHKHUYENMAI"];
            cbo();
            Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }

        private void dgvSachKM_SelectionChanged(object sender, EventArgs e)
        {
            //Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }

        public void Them(string s1, string s2, string s3)
        {
            try
            {
                if (s1.Length != 0)
                {
                    int a = getScalar(s2);
                    if (a == 0)
                    {
                        //string sql = "insert into KHUYENMAI VALUES ('" + txtMaKM.Text + "', '" + mskBD.Text + "','" + mskKT.Text + "', " + txtGiamGia.Text + " )"; ;
                        getNonquery(s3);
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã khuyến mãi đã tồn tại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void Xoa(string s1, string s2, string s3)
        {
            try
            {
                if (s1.Length != 0)
                {
                    int a = getScalar(s2);
                    if (a != 0)
                    {
                        //string sql = "insert into KHUYENMAI VALUES ('" + txtMaKM.Text + "', '" + mskBD.Text + "','" + mskKT.Text + "', " + txtGiamGia.Text + " )"; ;
                        getNonquery(s3);
                        MessageBox.Show(" Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Khuyến mãi không tồn tại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khuyến mãi đang được sử dụng");
            }
        }
        public void Sua(string s1, string s2, string s3)
        {
            try
            {
                if (s1.Length != 0)
                {
                    int a = getScalar(s2);
                    if (a != 0)
                    {
                        //string sql = "insert into KHUYENMAI VALUES ('" + txtMaKM.Text + "', '" + mskBD.Text + "','" + mskKT.Text + "', " + txtGiamGia.Text + " )"; ;
                        getNonquery(s3);
                        MessageBox.Show(" Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Khuyến mãi không tồn tại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khuyến mãi đang được sử dụng");
            }
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from KHUYENMAI where MAKM = '" + txtMaKM.Text + "'";
            string sql1 = "insert into KHUYENMAI VALUES ('" + txtMaKM.Text + "', '" + mskBD.Text + "','" + mskKT.Text + "', " + txtGiamGia.Text + " )";
            Them(txtMaKM.Text, sql, sql1);
            Refresh1();
            dgvKhuyenMai.DataSource = ds.Tables["KHUYENMAI"];
            cbo();
            Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from KHUYENMAI where MAKM = '" + txtMaKM.Text + "'";
            string sql1 = " delete from KHUYENMAI where MAKM = '" + txtMaKM.Text + "'";
            Xoa(txtMaKM.Text, sql, sql1);
            Refresh1();
            dgvKhuyenMai.DataSource = ds.Tables["KHUYENMAI"];
            cbo();
            Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from KHUYENMAI where MAKM = '" + txtMaKM.Text + "'";
            string sql1 = " UPDATE KHUYENMAI SET NGAYBD = '"+mskBD.Text+"', NGAYKT ='"+mskKT.Text+"', GIAMGIA = '"+txtGiamGia.Text+"' where MAKM = '" + txtMaKM.Text + "'";
            Sua(txtMaKM.Text, sql, sql1);
            Refresh1();
            dgvKhuyenMai.DataSource = ds.Tables["KHUYENMAI"];
            cbo();
            Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from SACHKHUYENMAI where ID = '" + txtID.Text + "'";
            string sql1 = "insert into SACHKHUYENMAI VALUES ("+txtID.Text+", '"+cboMaSach.SelectedValue+"','"+cboMaSachKM.Text+"')";
            Them(txtID.Text, sql, sql1);
            Refresh1();
            dgvSachKM.DataSource = ds.Tables["SACHKHUYENMAI"];
            cbo();
            Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from SACHKHUYENMAI where ID = '" + txtID.Text + "'";
            string sql1 = " delete from SACHKHUYENMAI where ID = '" + txtID.Text + "'";
            Xoa(txtID.Text, sql, sql1);
            Refresh1();
            dgvSachKM.DataSource = ds.Tables["SACHKHUYENMAI"];
            cbo();
            Databinding(ds.Tables["KHUYENMAI"], ds.Tables["SACHKHUYENMAI"]);
        }
    }
}
