using Microsoft.VisualBasic.ApplicationServices;

namespace QuanLyNhaSach
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.groupAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnNhapKho = new FontAwesome.Sharp.IconButton();
            this.btnXuLyHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnQuanLySach = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnThuPhongMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnPhucHoi = new FontAwesome.Sharp.IconButton();
            this.btnSaoLuu = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.ChucVu = new System.Windows.Forms.Label();
            this.SoDT = new System.Windows.Forms.Label();
            this.sddc = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnQuanLyKhachHang = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.groupAdmin.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnQuanLyKhachHang);
            this.panelMenu.Controls.Add(this.groupAdmin);
            this.panelMenu.Controls.Add(this.btnNhapKho);
            this.panelMenu.Controls.Add(this.btnXuLyHoaDon);
            this.panelMenu.Controls.Add(this.btnQuanLySach);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.panelTop);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(274, 698);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Tag = "panelMenu";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDangXuat.IconColor = System.Drawing.Color.White;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 638);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(274, 60);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Tag = "Đăng xuất";
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupAdmin
            // 
            this.groupAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.groupAdmin.Controls.Add(this.btnAdmin);
            this.groupAdmin.Controls.Add(this.btnQuanLyTaiKhoan);
            this.groupAdmin.Controls.Add(this.btnKhuyenMai);
            this.groupAdmin.Controls.Add(this.btnQuanLyNhanVien);
            this.groupAdmin.Location = new System.Drawing.Point(0, 450);
            this.groupAdmin.Name = "groupAdmin";
            this.groupAdmin.Size = new System.Drawing.Size(274, 60);
            this.groupAdmin.TabIndex = 11;
            this.groupAdmin.Tag = "groupAdmin";
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(3, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdmin.Size = new System.Drawing.Size(274, 60);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Tag = "Admin";
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnQuanLyTaiKhoan.IconColor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(3, 69);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(274, 60);
            this.btnQuanLyTaiKhoan.TabIndex = 10;
            this.btnQuanLyTaiKhoan.Tag = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            this.btnKhuyenMai.IconColor = System.Drawing.Color.White;
            this.btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhuyenMai.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKhuyenMai.Location = new System.Drawing.Point(3, 135);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhuyenMai.Size = new System.Drawing.Size(274, 60);
            this.btnKhuyenMai.TabIndex = 12;
            this.btnKhuyenMai.Tag = "Khuyến mãi";
            this.btnKhuyenMai.Text = "Khuyến mãi";
            this.btnKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhuyenMai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnQuanLyNhanVien.IconColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(3, 201);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(274, 60);
            this.btnQuanLyNhanVien.TabIndex = 9;
            this.btnQuanLyNhanVien.Tag = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnNhapKho.IconColor = System.Drawing.Color.White;
            this.btnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Location = new System.Drawing.Point(0, 324);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhapKho.Size = new System.Drawing.Size(274, 60);
            this.btnNhapKho.TabIndex = 5;
            this.btnNhapKho.Tag = "Xử lý nhập kho";
            this.btnNhapKho.Text = "Xử lý nhập kho";
            this.btnNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnXuLyHoaDon
            // 
            this.btnXuLyHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuLyHoaDon.FlatAppearance.BorderSize = 0;
            this.btnXuLyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLyHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuLyHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnXuLyHoaDon.IconColor = System.Drawing.Color.White;
            this.btnXuLyHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuLyHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyHoaDon.Location = new System.Drawing.Point(0, 264);
            this.btnXuLyHoaDon.Name = "btnXuLyHoaDon";
            this.btnXuLyHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXuLyHoaDon.Size = new System.Drawing.Size(274, 60);
            this.btnXuLyHoaDon.TabIndex = 4;
            this.btnXuLyHoaDon.Tag = "Xử lý hóa đơn";
            this.btnXuLyHoaDon.Text = "Xử lý hóa đơn";
            this.btnXuLyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuLyHoaDon.UseVisualStyleBackColor = true;
            this.btnXuLyHoaDon.Click += new System.EventHandler(this.btnXuLyHoaDon_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLySach.FlatAppearance.BorderSize = 0;
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySach.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQuanLySach.IconColor = System.Drawing.Color.White;
            this.btnQuanLySach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySach.Location = new System.Drawing.Point(0, 204);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQuanLySach.Size = new System.Drawing.Size(274, 60);
            this.btnQuanLySach.TabIndex = 3;
            this.btnQuanLySach.Tag = "Quản lý sách";
            this.btnQuanLySach.Text = "Quản lý sách";
            this.btnQuanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 144);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(274, 60);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Tag = "Thống kê";
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnThuPhongMenu);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(274, 144);
            this.panelTop.TabIndex = 2;
            this.panelTop.Tag = "top";
            // 
            // btnThuPhongMenu
            // 
            this.btnThuPhongMenu.FlatAppearance.BorderSize = 0;
            this.btnThuPhongMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuPhongMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnThuPhongMenu.IconColor = System.Drawing.Color.White;
            this.btnThuPhongMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThuPhongMenu.Location = new System.Drawing.Point(188, 7);
            this.btnThuPhongMenu.Name = "btnThuPhongMenu";
            this.btnThuPhongMenu.Size = new System.Drawing.Size(75, 56);
            this.btnThuPhongMenu.TabIndex = 4;
            this.btnThuPhongMenu.Tag = "menu";
            this.btnThuPhongMenu.UseVisualStyleBackColor = true;
            this.btnThuPhongMenu.Click += new System.EventHandler(this.btnThuPhongMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhaSach.Properties.Resources._5900198;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "logo";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.guna2ControlBox3);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.guna2ControlBox2);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.guna2ControlBox1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(274, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(974, 63);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(806, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(55, 33);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitleChildForm.Location = new System.Drawing.Point(70, 12);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(157, 41);
            this.lblTitleChildForm.TabIndex = 3;
            this.lblTitleChildForm.Text = "Trang chủ";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(861, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(55, 33);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 45;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(46, 45);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(916, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(55, 33);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Controls.Add(this.btnPhucHoi);
            this.panelDesktop.Controls.Add(this.btnSaoLuu);
            this.panelDesktop.Controls.Add(this.groupBox1);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(274, 63);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(974, 635);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPhucHoi.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPhucHoi.FlatAppearance.BorderSize = 0;
            this.btnPhucHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhucHoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhucHoi.ForeColor = System.Drawing.Color.White;
            this.btnPhucHoi.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnPhucHoi.IconColor = System.Drawing.Color.White;
            this.btnPhucHoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhucHoi.IconSize = 30;
            this.btnPhucHoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhucHoi.Location = new System.Drawing.Point(382, 522);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnPhucHoi.Size = new System.Drawing.Size(291, 54);
            this.btnPhucHoi.TabIndex = 56;
            this.btnPhucHoi.Tag = "Xóa";
            this.btnPhucHoi.Text = "Phục hồi DataBase";
            this.btnPhucHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhucHoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhucHoi.UseVisualStyleBackColor = false;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaoLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.btnSaoLuu.FlatAppearance.BorderSize = 0;
            this.btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaoLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.ForeColor = System.Drawing.Color.White;
            this.btnSaoLuu.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSaoLuu.IconColor = System.Drawing.Color.White;
            this.btnSaoLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaoLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaoLuu.Location = new System.Drawing.Point(39, 522);
            this.btnSaoLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSaoLuu.Size = new System.Drawing.Size(291, 54);
            this.btnSaoLuu.TabIndex = 55;
            this.btnSaoLuu.Tag = "Sửa";
            this.btnSaoLuu.Text = "Sao lưu DataBase";
            this.btnSaoLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaoLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaoLuu.UseVisualStyleBackColor = false;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.ChucVu);
            this.groupBox1.Controls.Add(this.SoDT);
            this.groupBox1.Controls.Add(this.sddc);
            this.groupBox1.Controls.Add(this.DiaChi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 335);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(660, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 34);
            this.txtEmail.TabIndex = 24;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(660, 44);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(230, 34);
            this.txtChucVu.TabIndex = 23;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(252, 146);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(257, 34);
            this.txtHoTen.TabIndex = 22;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(660, 146);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(230, 34);
            this.txtSoDT.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(252, 250);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(257, 34);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(252, 44);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(257, 34);
            this.txtMaNV.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(552, 253);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(74, 29);
            this.Email.TabIndex = 18;
            this.Email.Text = "Email";
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSize = true;
            this.ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVu.Location = new System.Drawing.Point(552, 44);
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Size = new System.Drawing.Size(102, 29);
            this.ChucVu.TabIndex = 17;
            this.ChucVu.Text = "Chức Vụ";
            // 
            // SoDT
            // 
            this.SoDT.AutoSize = true;
            this.SoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDT.Location = new System.Drawing.Point(552, 146);
            this.SoDT.Name = "SoDT";
            this.SoDT.Size = new System.Drawing.Size(82, 29);
            this.SoDT.TabIndex = 16;
            this.SoDT.Text = "Số DT";
            // 
            // sddc
            // 
            this.sddc.AutoSize = true;
            this.sddc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sddc.Location = new System.Drawing.Point(36, 149);
            this.sddc.Name = "sddc";
            this.sddc.Size = new System.Drawing.Size(210, 29);
            this.sddc.TabIndex = 15;
            this.sddc.Text = "Họ Tên Nhân Viên";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.Location = new System.Drawing.Point(36, 253);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(91, 29);
            this.DiaChi.TabIndex = 14;
            this.DiaChi.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Nhân Viên";
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 1;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnQuanLyKhachHang.IconColor = System.Drawing.Color.White;
            this.btnQuanLyKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyKhachHang.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(0, 384);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(274, 60);
            this.btnQuanLyKhachHang.TabIndex = 7;
            this.btnQuanLyKhachHang.Tag = "Quản lý khách hàng";
            this.btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.btnQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 698);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.groupAdmin.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnThuPhongMenu;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnNhapKho;
        private FontAwesome.Sharp.IconButton btnXuLyHoaDon;
        private FontAwesome.Sharp.IconButton btnQuanLySach;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private FontAwesome.Sharp.IconButton btnQuanLyTaiKhoan;
        private FontAwesome.Sharp.IconButton btnQuanLyNhanVien;
        private System.Windows.Forms.FlowLayoutPanel groupAdmin;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label ChucVu;
        private System.Windows.Forms.Label SoDT;
        private System.Windows.Forms.Label sddc;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnSaoLuu;
        private FontAwesome.Sharp.IconButton btnPhucHoi;
        private FontAwesome.Sharp.IconButton btnQuanLyKhachHang;
    }
}