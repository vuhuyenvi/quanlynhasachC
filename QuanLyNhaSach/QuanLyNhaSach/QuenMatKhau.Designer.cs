namespace QuanLyNhaSach
{
    partial class QuenMatKhau
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGui = new System.Windows.Forms.Button();
            this.txtNhapMaCaptCha = new System.Windows.Forms.TextBox();
            this.txtMaCaptcha = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhaSach.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(98, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 245);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 28);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã Captcha";
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(228, 371);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(127, 43);
            this.btnGui.TabIndex = 3;
            this.btnGui.Text = "Lấy mật khẩu";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNhapMaCaptCha
            // 
            this.txtNhapMaCaptCha.Location = new System.Drawing.Point(228, 312);
            this.txtNhapMaCaptCha.Multiline = true;
            this.txtNhapMaCaptCha.Name = "txtNhapMaCaptCha";
            this.txtNhapMaCaptCha.Size = new System.Drawing.Size(127, 28);
            this.txtNhapMaCaptCha.TabIndex = 1;
            // 
            // txtMaCaptcha
            // 
            this.txtMaCaptcha.Enabled = false;
            this.txtMaCaptcha.Location = new System.Drawing.Point(382, 312);
            this.txtMaCaptcha.Multiline = true;
            this.txtMaCaptcha.Name = "txtMaCaptcha";
            this.txtMaCaptcha.Size = new System.Drawing.Size(127, 28);
            this.txtMaCaptcha.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(382, 371);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 43);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaCaptcha);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapMaCaptCha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMatKhau";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txtNhapMaCaptCha;
        private System.Windows.Forms.TextBox txtMaCaptcha;
        private System.Windows.Forms.Button btnThoat;
    }
}