namespace QuanLyNhaSach
{
    partial class QuanLySach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSach = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYXUATBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTraCuu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTraCuu = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLocSach = new MetroFramework.Controls.MetroComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnThemSach = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSach.ColumnHeadersHeight = 40;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASACH,
            this.TENNXB,
            this.TENTL,
            this.TENSACH,
            this.TENTG,
            this.NGAYXUATBAN,
            this.GIABAN,
            this.SOLUONGTON});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvSach.DoubleBuffered = true;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvSach.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSach.Location = new System.Drawing.Point(12, 76);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSach.RowTemplate.Height = 50;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1206, 532);
            this.dgvSach.TabIndex = 7;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            this.dgvSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellDoubleClick);
            this.dgvSach.SelectionChanged += new System.EventHandler(this.dgvSach_SelectionChanged);
            // 
            // MASACH
            // 
            this.MASACH.DataPropertyName = "MASACH";
            this.MASACH.HeaderText = "Mã sách";
            this.MASACH.MinimumWidth = 6;
            this.MASACH.Name = "MASACH";
            this.MASACH.ReadOnly = true;
            // 
            // TENNXB
            // 
            this.TENNXB.DataPropertyName = "TENNXB";
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
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.HeaderText = "Tên sách";
            this.TENSACH.MinimumWidth = 6;
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.ReadOnly = true;
            // 
            // TENTG
            // 
            this.TENTG.DataPropertyName = "TENTG";
            this.TENTG.HeaderText = "Tên tác giả";
            this.TENTG.MinimumWidth = 6;
            this.TENTG.Name = "TENTG";
            this.TENTG.ReadOnly = true;
            // 
            // NGAYXUATBAN
            // 
            this.NGAYXUATBAN.DataPropertyName = "NGAYXUATBAN";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.NGAYXUATBAN.DefaultCellStyle = dataGridViewCellStyle15;
            this.NGAYXUATBAN.HeaderText = "Ngày xuất bản";
            this.NGAYXUATBAN.MinimumWidth = 6;
            this.NGAYXUATBAN.Name = "NGAYXUATBAN";
            this.NGAYXUATBAN.ReadOnly = true;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            dataGridViewCellStyle16.Format = "C0";
            dataGridViewCellStyle16.NullValue = null;
            this.GIABAN.DefaultCellStyle = dataGridViewCellStyle16;
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.DataPropertyName = "SOLUONGTON";
            this.SOLUONGTON.HeaderText = "Số lượng tồn";
            this.SOLUONGTON.MinimumWidth = 6;
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.ReadOnly = true;
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.txtTraCuu.BorderRadius = 5;
            this.txtTraCuu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuu.DefaultText = "";
            this.txtTraCuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuu.Location = new System.Drawing.Point(12, 22);
            this.txtTraCuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.PasswordChar = '\0';
            this.txtTraCuu.PlaceholderText = "";
            this.txtTraCuu.SelectedText = "";
            this.txtTraCuu.Size = new System.Drawing.Size(375, 35);
            this.txtTraCuu.TabIndex = 12;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.btnTraCuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.BorderRadius = 5;
            this.btnTraCuu.BorderThickness = 2;
            this.btnTraCuu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.CustomBorderColor = System.Drawing.Color.White;
            this.btnTraCuu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTraCuu.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.FillColor = System.Drawing.Color.White;
            this.btnTraCuu.FocusedColor = System.Drawing.Color.White;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraCuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTraCuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(406, 22);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.PressedColor = System.Drawing.Color.Blue;
            this.btnTraCuu.Size = new System.Drawing.Size(109, 35);
            this.btnTraCuu.TabIndex = 13;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(848, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lọc sách theo: ";
            // 
            // cboLocSach
            // 
            this.cboLocSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLocSach.FormattingEnabled = true;
            this.cboLocSach.ItemHeight = 24;
            this.cboLocSach.Items.AddRange(new object[] {
            "Tên sách",
            "Nhà xuất bản",
            "Thể loại",
            "Tác giả"});
            this.cboLocSach.Location = new System.Drawing.Point(992, 27);
            this.cboLocSach.Name = "cboLocSach";
            this.cboLocSach.Size = new System.Drawing.Size(226, 30);
            this.cboLocSach.TabIndex = 22;
            this.cboLocSach.UseSelectable = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaSáchToolStripMenuItem,
            this.sửaSáchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 52);
            // 
            // xóaSáchToolStripMenuItem
            // 
            this.xóaSáchToolStripMenuItem.Name = "xóaSáchToolStripMenuItem";
            this.xóaSáchToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.xóaSáchToolStripMenuItem.Text = "Xóa sách";
            // 
            // sửaSáchToolStripMenuItem
            // 
            this.sửaSáchToolStripMenuItem.Name = "sửaSáchToolStripMenuItem";
            this.sửaSáchToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.sửaSáchToolStripMenuItem.Text = "Sửa sách";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(420, 614);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSua.Size = new System.Drawing.Size(191, 60);
            this.btnSua.TabIndex = 24;
            this.btnSua.Tag = "Sửa";
            this.btnSua.Text = "Sửa sách";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnHuy.IconColor = System.Drawing.Color.White;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(216, 614);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHuy.Size = new System.Drawing.Size(191, 60);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Tag = "Xóa";
            this.btnHuy.Text = "Hủy sách";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThemSach.FlatAppearance.BorderSize = 0;
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnThemSach.IconColor = System.Drawing.Color.White;
            this.btnThemSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.Location = new System.Drawing.Point(12, 614);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThemSach.Size = new System.Drawing.Size(191, 60);
            this.btnThemSach.TabIndex = 25;
            this.btnThemSach.Tag = "Xóa";
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLyNhaSach.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 686);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cboLocSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.dgvSach);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSach;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuu;
        private Guna.UI2.WinForms.Guna2Button btnTraCuu;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cboLocSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYXUATBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTON;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaSáchToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnThemSach;
    }
}