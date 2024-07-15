using QuanLyNhaSach.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.DAO;
using System.Threading;
using System.Xml.Linq;

namespace QuanLyNhaSach
{
    public partial class QuenMatKhau : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataSet ds = new DataSet();
        DBConnect db = new DBConnect();

        private const int CaptchaLength = 6; // Độ dài của mã Captcha
        private string captchaCode = string.Empty;
        public QuenMatKhau()
        {
            conn = new SqlConnection(KetNoi.trConn);
            InitializeComponent();
        }
        private void GenerateCaptcha()
        {
            captchaCode = GenerateRandomCaptcha(CaptchaLength);
            txtMaCaptcha.Text = captchaCode;
        }

        private string GenerateRandomCaptcha(int length)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] captcha = new char[length];

            for (int i = 0; i < length; i++)
            {
                captcha[i] = characters[random.Next(characters.Length)];
            }

            return new string(captcha);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNhapMaCaptCha.Text != txtMaCaptcha.Text)
            {
                MessageBox.Show("Mã đã nhập không đúng");
                GenerateCaptcha();
                txtNhapMaCaptCha.Clear();
                return;
            }
            if(txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập email");
                return;
            }
            else
            {
                string sql = "select MATKHAU from NHANVIEN, TAIKHOAN where NHANVIEN.MANV=TAIKHOAN.MANV AND EMAILNV = '" + txtEmail.Text + "'";
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count>0)
                {
                    string password = db.getScalar(sql).ToString();
                    string email = txtEmail.Text;
                    SendPasswordByEmail(email, password);
                    MessageBox.Show("Mật khẩu đã được gửi về email.");
                }
                else
                {
                    MessageBox.Show("Người dùng này chưa được đăng ký");
                    txtEmail.Clear();
                    txtNhapMaCaptCha.Clear() ;
                    GenerateCaptcha();
                    return;
                }
            }    
            
        }
        private void SendPasswordByEmail(string toEmail, string password)
        {
            try
            {
                string subject = "Mật khẩu của bạn";
                string body = "Mật khẩu là: "+password;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("vuhuyenvi2003@gmail.com"); 
                    mail.To.Add(toEmail);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com")) 
                    {
                        smtp.Port = 587; 
                        smtp.Credentials = new NetworkCredential("vuhuyenvi2003@gmail.com", "byrtkenpmheaojil");
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: "+ex.Message);
            }
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
            
        }
        private void txtNhapMaCaptCha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangNhap1 dn1 = new DangNhap1();
            dn1.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
