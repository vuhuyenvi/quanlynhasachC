using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLNhanVIen;
using QuanLyNhaSach.Class;
using QuanLyNhaSach.DAO;

namespace QuanLyNhaSach
{
    public partial class Home : Form
    {
        DBConnect db = new DBConnect();
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string taiKhoan;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public Home()
        {
            InitializeComponent();
            CollapseMenu();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public Home(string  taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            InitializeComponent();
            CollapseMenu();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(220, 212, 203);
            public static Color color8 = Color.FromArgb(220, 21, 103);
            public static Color color9 = Color.FromArgb(20, 212, 203);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(98, 102, 244);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }



        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ThongKe(z));
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new QuanLySach());
        }

        private void btnXuLyHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new XuLyHoaDon());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string sql = "Select PHANQUYEN FROM TAIKHOAN WHERE TENDN = '" + taiKhoan + "'";
            string phanQuyen = (string)db.getScalar(sql);
            if(phanQuyen == "Admin")
            {
                ActivateButton(sender, RGBColors.color5);
                menuTransition.Start();
            }
            else
            {
                MessageBox.Show("Chỉ có Admin mới được sử dụng chức năng này","Thông báo!!!");
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new XuLyNhapKho());
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new QuanLyKhachHang());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            if(MessageBox.Show("Bạn có muốn đăng xuất?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                this.Close();
        }



        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnThuPhongMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnThuPhongMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                groupAdmin.Width = 100;
                foreach (Button menuButton in groupAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 274;
                pictureBox1.Visible = true;
                btnThuPhongMenu.Dock = DockStyle.None;
                groupAdmin.Width = 274;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in groupAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        bool menuExpand = false;

        

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                groupAdmin.Height += 10;
                if(groupAdmin.Height >= 274)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                groupAdmin.Height -= 10;
                if (groupAdmin.Height <= 60)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormQuanLyNhanVien());
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(new QuanLyTaiKhoan());
        }
        string z;

        private void Home_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            z = KiemTra();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(new QuanLyKhuyenMai());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        public string KiemTra()
        {
            SqlConnection conn = new SqlConnection(KetNoi.trConn);

            SqlDataAdapter adapt = new SqlDataAdapter("select NHANVIEN.MANV, TENCV, HOTENNV, DIACHINV, SODT, EMAILNV from NHANVIEN,TAIKHOAN,CHUCVU where NHANVIEN.MANV = TAIKHOAN.MANV and NHANVIEN.MACV = CHUCVU.MACV and TAIKHOAN.TENDN = '"+TaiKhoan+"'", conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                txtMaNV.Text = dr["MANV"].ToString();
                txtHoTen.Text = dr["HOTENNV"].ToString();
                txtChucVu.Text = dr["TENCV"].ToString();
                txtDiaChi.Text = dr["DIACHINV"].ToString();
                txtSoDT.Text = "0" + dr["SODT"].ToString();
                txtEmail.Text = dr["EMAILNV"].ToString();
            }
            return txtHoTen.Text;
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            bool bBackUpStatus = true;

            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"C:\Users\Vu Thi Huyen Vi\Desktop\Nhom04_QuanLyNhaSach\BackUp"))
            {
                if (File.Exists(@"C:\Users\Vu Thi Huyen Vi\Desktop\Nhom04_QuanLyNhaSach\BackUp\QLNS.bak"))
                {
                    if (MessageBox.Show(@"Do you want to replace it?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"C:\Users\Vu Thi Huyen Vi\Desktop\Nhom04_QuanLyNhaSach\BackUp\QLNS.bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
                Directory.CreateDirectory(@"C:\Users\Vu Thi Huyen Vi\Desktop\Nhom04_QuanLyNhaSach\BackUp");

            if (bBackUpStatus)
            {
                SqlConnection connect;
                connect = new SqlConnection(KetNoi.trConn);
                connect.Open();

                SqlCommand command;
                command = new SqlCommand(@"backup database QLNS to disk ='D:\QLNS.bak' with init,stats=10", connect);
                command.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Hỗ trợ sao lưu DataBase thành công", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"C:\Users\Vu Thi Huyen Vi\Desktop\Nhom04_QuanLyNhaSach\BackUp\QLNS.bak"))
                {
                    if (MessageBox.Show("Bạn có muốn phục hồi DataBase?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection connect;
                        connect = new SqlConnection(KetNoi.trConn);
                        connect.Open();

                        SqlCommand command;
                        command = new SqlCommand("use master", connect);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(@"restore database QLNS from disk = 'C:\Users\Vu Thi Huyen Vi\Desktop\Nhom04_QuanLyNhaSach\BackUp\QLNS.bak'", connect);
                        command.ExecuteNonQuery();
                        connect.Close();

                        MessageBox.Show("Cơ sở dữ liệu đã được khôi phục", "Khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(@"Không thực hiện bất kỳ xác nhận nào ở trên (hoặc không đúng đường dẫn)", "Khôi phục", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


    }
}
