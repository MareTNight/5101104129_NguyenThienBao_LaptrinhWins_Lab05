namespace CourseRegistrationApp
{
    partial class Form1
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
            this.grpHocVien = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpKhoaHoc = new System.Windows.Forms.GroupBox();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblHocPhi = new System.Windows.Forms.Label();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpHocVien.SuspendLayout();
            this.grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHocVien
            // 
            this.grpHocVien.Controls.Add(this.txtSoDienThoai);
            this.grpHocVien.Controls.Add(this.txtHoTen);
            this.grpHocVien.Controls.Add(this.dtpNgaySinh);
            this.grpHocVien.Controls.Add(this.chkNhanEmail);
            this.grpHocVien.Controls.Add(this.lblNgaySinh);
            this.grpHocVien.Controls.Add(this.lblSoDienThoai);
            this.grpHocVien.Controls.Add(this.lblHoTen);
            this.grpHocVien.Location = new System.Drawing.Point(38, 41);
            this.grpHocVien.Name = "grpHocVien";
            this.grpHocVien.Size = new System.Drawing.Size(427, 177);
            this.grpHocVien.TabIndex = 0;
            this.grpHocVien.TabStop = false;
            this.grpHocVien.Text = "Thông tin học viên";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(114, 63);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(154, 22);
            this.txtSoDienThoai.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(114, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(154, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Location = new System.Drawing.Point(114, 99);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(247, 22);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Location = new System.Drawing.Point(132, 137);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(160, 20);
            this.chkNhanEmail.TabIndex = 3;
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            this.chkNhanEmail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 99);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(15, 69);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(88, 16);
            this.lblSoDienThoai.TabIndex = 1;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            this.lblSoDienThoai.Click += new System.EventHandler(this.lblSoDienThoai_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 38);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // grpKhoaHoc
            // 
            this.grpKhoaHoc.Controls.Add(this.numSoThang);
            this.grpKhoaHoc.Controls.Add(this.radOffline);
            this.grpKhoaHoc.Controls.Add(this.radOnline);
            this.grpKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.grpKhoaHoc.Controls.Add(this.lblTongTien);
            this.grpKhoaHoc.Controls.Add(this.lblHocPhi);
            this.grpKhoaHoc.Controls.Add(this.lblSoThang);
            this.grpKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.grpKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.grpKhoaHoc.Location = new System.Drawing.Point(38, 261);
            this.grpKhoaHoc.Name = "grpKhoaHoc";
            this.grpKhoaHoc.Size = new System.Drawing.Size(314, 155);
            this.grpKhoaHoc.TabIndex = 1;
            this.grpKhoaHoc.TabStop = false;
            this.grpKhoaHoc.Text = "Thông tin khóa học";
            // 
            // numSoThang
            // 
            this.numSoThang.Location = new System.Drawing.Point(99, 90);
            this.numSoThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSoThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(120, 22);
            this.numSoThang.TabIndex = 3;
            this.numSoThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);
            // 
            // radOffline
            // 
            this.radOffline.AutoSize = true;
            this.radOffline.Location = new System.Drawing.Point(182, 59);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(65, 20);
            this.radOffline.TabIndex = 2;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Offline";
            this.radOffline.UseVisualStyleBackColor = true;
            this.radOffline.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Location = new System.Drawing.Point(110, 59);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(66, 20);
            this.radOnline.TabIndex = 1;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(99, 26);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(121, 24);
            this.cboKhoaHoc.TabIndex = 2;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(111, 126);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(45, 16);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblHocPhi
            // 
            this.lblHocPhi.AutoSize = true;
            this.lblHocPhi.Location = new System.Drawing.Point(15, 126);
            this.lblHocPhi.Name = "lblHocPhi";
            this.lblHocPhi.Size = new System.Drawing.Size(88, 16);
            this.lblHocPhi.TabIndex = 10;
            this.lblHocPhi.Text = "Tổng học phí:";
            // 
            // lblSoThang
            // 
            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Location = new System.Drawing.Point(15, 92);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Size = new System.Drawing.Size(63, 16);
            this.lblSoThang.TabIndex = 9;
            this.lblSoThang.Text = "Số tháng:";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(15, 61);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(89, 16);
            this.lblHinhThuc.TabIndex = 8;
            this.lblHinhThuc.Text = "Hình thức học:";
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Location = new System.Drawing.Point(15, 29);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(66, 16);
            this.lblKhoaHoc.TabIndex = 0;
            this.lblKhoaHoc.Text = "Khóa học:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(349, 446);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(461, 446);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(575, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 513);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpKhoaHoc);
            this.Controls.Add(this.grpHocVien);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHocVien.ResumeLayout(false);
            this.grpHocVien.PerformLayout();
            this.grpKhoaHoc.ResumeLayout(false);
            this.grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHocVien;
        private System.Windows.Forms.GroupBox grpKhoaHoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblHocPhi;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}

