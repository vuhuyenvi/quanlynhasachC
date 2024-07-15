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
    public partial class DangNhap1 : Form
    {
        public DangNhap1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0xa5, 0xd2, 0xfc);
            pictureBox2.BackColor = Color.FromArgb(0xE0, 0xED, 0xFE);
            pictureBox3.BackColor = Color.FromArgb(0xE0, 0xED, 0xFE);
        }

        bool login(string username, string password)
        {
            return Account.Instance.Login(username, password);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (login(tk, mk))
            {
                Program.homeForm = new Home(tk, mk);
                this.Hide();
                Program.homeForm.ShowDialog();
                this.Show();
                txtMatKhau.Clear();
                txtTaiKhoan.Clear();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
        }

        private void lblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.Show();

            this.Hide();
        }
    }
}
