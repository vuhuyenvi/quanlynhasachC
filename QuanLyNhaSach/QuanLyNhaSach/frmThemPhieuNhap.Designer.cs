namespace QuanLyNhaSach
{
    partial class frmThemPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnTaoPN = new FontAwesome.Sharp.IconButton();
            this.dtpNgayLapPhieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaSach = new FontAwesome.Sharp.IconButton();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.btnThemSach = new FontAwesome.Sharp.IconButton();
            this.txtNgayXuatBan = new System.Windows.Forms.MaskedTextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSachNhap = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MAPHIEUNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuPhieu = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 38);
            this.label2.TabIndex = 36;
            this.label2.Text = "PHIẾU NHẬP SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.btnTaoPN);
            this.groupBox1.Controls.Add(this.dtpNgayLapPhieu);
            this.groupBox1.Controls.Add(this.cboNhaCungCap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 142);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(133, 92);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(245, 28);
            this.cboNhanVien.TabIndex = 56;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.MediumPurple;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(769, 86);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.iconButton1.Size = new System.Drawing.Size(230, 47);
            this.iconButton1.TabIndex = 55;
            this.iconButton1.Tag = "Xóa";
            this.iconButton1.Text = "Reset";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.btnTaoPN.FlatAppearance.BorderSize = 0;
            this.btnTaoPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPN.ForeColor = System.Drawing.Color.White;
            this.btnTaoPN.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnTaoPN.IconColor = System.Drawing.Color.White;
            this.btnTaoPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaoPN.IconSize = 30;
            this.btnTaoPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPN.Location = new System.Drawing.Point(769, 24);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnTaoPN.Size = new System.Drawing.Size(230, 47);
            this.btnTaoPN.TabIndex = 54;
            this.btnTaoPN.Tag = "Xóa";
            this.btnTaoPN.Text = "Tạo phiếu nhập";
            this.btnTaoPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoPN.UseVisualStyleBackColor = false;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Checked = true;
            this.dtpNgayLapPhieu.FillColor = System.Drawing.Color.White;
            this.dtpNgayLapPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(507, 93);
            this.dtpNgayLapPhieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLapPhieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(245, 33);
            this.dtpNgayLapPhieu.TabIndex = 5;
            this.dtpNgayLapPhieu.Value = new System.DateTime(2023, 10, 10, 2, 35, 11, 282);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(507, 35);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(245, 28);
            this.cboNhaCungCap.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập phiếu:";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(133, 36);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(245, 27);
            this.txtMaPhieuNhap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhân viên nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaSach);
            this.groupBox2.Controls.Add(this.cboMaSach);
            this.groupBox2.Controls.Add(this.txtTG);
            this.groupBox2.Controls.Add(this.txtTL);
            this.groupBox2.Controls.Add(this.txtNXB);
            this.groupBox2.Controls.Add(this.btnThemSach);
            this.groupBox2.Controls.Add(this.txtNgayXuatBan);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 248);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoaSach.FlatAppearance.BorderSize = 0;
            this.btnXoaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSach.ForeColor = System.Drawing.Color.White;
            this.btnXoaSach.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaSach.IconColor = System.Drawing.Color.White;
            this.btnXoaSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaSach.IconSize = 30;
            this.btnXoaSach.Location = new System.Drawing.Point(923, 163);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(74, 47);
            this.btnXoaSach.TabIndex = 80;
            this.btnXoaSach.Tag = "Xóa";
            this.btnXoaSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaSach.UseVisualStyleBackColor = false;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(174, 36);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(186, 28);
            this.cboMaSach.TabIndex = 79;
            // 
            // txtTG
            // 
            this.txtTG.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Location = new System.Drawing.Point(517, 109);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(186, 30);
            this.txtTG.TabIndex = 78;
            // 
            // txtTL
            // 
            this.txtTL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.Location = new System.Drawing.Point(174, 184);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(186, 30);
            this.txtTL.TabIndex = 77;
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(174, 112);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(186, 30);
            this.txtNXB.TabIndex = 76;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThemSach.FlatAppearance.BorderSize = 0;
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnThemSach.IconColor = System.Drawing.Color.White;
            this.btnThemSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSach.IconSize = 30;
            this.btnThemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.Location = new System.Drawing.Point(733, 163);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Padding = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.btnThemSach.Size = new System.Drawing.Size(173, 47);
            this.btnThemSach.TabIndex = 74;
            this.btnThemSach.Tag = "Xóa";
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtNgayXuatBan
            // 
            this.txtNgayXuatBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayXuatBan.Location = new System.Drawing.Point(517, 184);
            this.txtNgayXuatBan.Mask = "00/00/0000";
            this.txtNgayXuatBan.Name = "txtNgayXuatBan";
            this.txtNgayXuatBan.Size = new System.Drawing.Size(186, 30);
            this.txtNgayXuatBan.TabIndex = 69;
            this.txtNgayXuatBan.ValidatingType = typeof(System.DateTime);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(849, 109);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(148, 30);
            this.txtSoLuong.TabIndex = 68;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(849, 34);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(148, 30);
            this.txtGiaNhap.TabIndex = 67;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(517, 34);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(186, 30);
            this.txtTenSach.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(729, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 65;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(729, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 63;
            this.label6.Text = "Ngày xuất bản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(390, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tên tác giả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(390, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 61;
            this.label10.Text = "Tên sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "Tên thể loại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "Tên nhà xuất bản";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 58;
            this.label13.Text = "Mã sách";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(11, 873);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnCancel.Size = new System.Drawing.Size(148, 49);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Tag = "Thêm";
            this.btnCancel.Text = "Hủy phiếu";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(798, 892);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(186, 30);
            this.txtThanhTien.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(671, 895);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 23);
            this.label14.TabIndex = 67;
            this.label14.Text = "Tổng cộng:";
            // 
            // dgvSachNhap
            // 
            this.dgvSachNhap.AllowUserToAddRows = false;
            this.dgvSachNhap.AllowUserToDeleteRows = false;
            this.dgvSachNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSachNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSachNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSachNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSachNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSachNhap.ColumnHeadersHeight = 40;
            this.dgvSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSachNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEUNHAP,
            this.dataGridViewTextBoxColumn1,
            this.TENNXB,
            this.TENTL,
            this.dataGridViewTextBoxColumn2,
            this.TENTG,
            this.dataGridViewTextBoxColumn3,
            this.GIANHAP,
            this.SOLUONGNHAP});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSachNhap.DoubleBuffered = true;
            this.dgvSachNhap.EnableHeadersVisualStyles = false;
            this.dgvSachNhap.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvSachNhap.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSachNhap.Location = new System.Drawing.Point(11, 465);
            this.dgvSachNhap.Name = "dgvSachNhap";
            this.dgvSachNhap.ReadOnly = true;
            this.dgvSachNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSachNhap.RowHeadersVisible = false;
            this.dgvSachNhap.RowHeadersWidth = 51;
            this.dgvSachNhap.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSachNhap.RowTemplate.Height = 50;
            this.dgvSachNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachNhap.Size = new System.Drawing.Size(1011, 398);
            this.dgvSachNhap.TabIndex = 77;
            this.dgvSachNhap.SelectionChanged += new System.EventHandler(this.dgvSachNhap_SelectionChanged);
            // 
            // MAPHIEUNHAP
            // 
            this.MAPHIEUNHAP.DataPropertyName = "MAPHIEUNHAP";
            this.MAPHIEUNHAP.HeaderText = "Mã phiếu nhập";
            this.MAPHIEUNHAP.MinimumWidth = 6;
            this.MAPHIEUNHAP.Name = "MAPHIEUNHAP";
            this.MAPHIEUNHAP.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASACH";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TENNXB
            // 
            this.TENNXB.DataPropertyName = "TENNXB";
            this.TENNXB.FillWeight = 110F;
            this.TENNXB.HeaderText = "Tên nhà xuất bản";
            this.TENNXB.MinimumWidth = 6;
            this.TENNXB.Name = "TENNXB";
            this.TENNXB.ReadOnly = true;
            // 
            // TENTL
            // 
            this.TENTL.DataPropertyName = "TENTL";
            this.TENTL.HeaderText = "Tên thể loại";
            this.TENTL.MinimumWidth = 6;
            this.TENTL.Name = "TENTL";
            this.TENTL.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENSACH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TENTG
            // 
            this.TENTG.DataPropertyName = "TENTG";
            this.TENTG.HeaderText = "Tên tác giả";
            this.TENTG.MinimumWidth = 6;
            this.TENTG.Name = "TENTG";
            this.TENTG.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYXUATBAN";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày xuất bản";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.GIANHAP.DefaultCellStyle = dataGridViewCellStyle4;
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.MinimumWidth = 6;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.ReadOnly = true;
            // 
            // SOLUONGNHAP
            // 
            this.SOLUONGNHAP.DataPropertyName = "SOLUONGNHAP";
            this.SOLUONGNHAP.HeaderText = "Số lượng nhập";
            this.SOLUONGNHAP.MinimumWidth = 6;
            this.SOLUONGNHAP.Name = "SOLUONGNHAP";
            this.SOLUONGNHAP.ReadOnly = true;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLuuPhieu.FlatAppearance.BorderSize = 0;
            this.btnLuuPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieu.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnLuuPhieu.IconColor = System.Drawing.Color.White;
            this.btnLuuPhieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuPhieu.IconSize = 30;
            this.btnLuuPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhieu.Location = new System.Drawing.Point(185, 873);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Padding = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.btnLuuPhieu.Size = new System.Drawing.Size(148, 49);
            this.btnLuuPhieu.TabIndex = 78;
            this.btnLuuPhieu.Tag = "Thêm";
            this.btnLuuPhieu.Text = "Lưu phiếu";
            this.btnLuuPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // frmThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 937);
            this.Controls.Add(this.btnLuuPhieu);
            this.Controls.Add(this.dgvSachNhap);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmThemPhieuNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThemPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmThemPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTaoPN;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnThemSach;
        private System.Windows.Forms.MaskedTextBox txtNgayXuatBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSachNhap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGNHAP;
        private FontAwesome.Sharp.IconButton btnXoaSach;
        private FontAwesome.Sharp.IconButton btnLuuPhieu;
    }
}