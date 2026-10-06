using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int LayHocPhiMotThang()
        {
            switch (cboKhoaHoc.SelectedIndex)
            {
                case 0:
                    return 800000;

                case 1:
                    return 700000;

                case 2:
                    return 750000;

                case 3:
                    return 650000;

                default:
                    return 0;
            }
        }
        private void CapNhatTongTien()
        {
            int soThang = (int)numSoThang.Value;
            int tongTien = LayHocPhiMotThang() * soThang;

            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Clear();
            cboKhoaHoc.Items.Add("C# Winsform cơ bản");
            cboKhoaHoc.Items.Add("SQL Server cơ bản");
            cboKhoaHoc.Items.Add("Web Frontend cơ bản");
            cboKhoaHoc.Items.Add("Lập trình Python cơ bản");
            cboKhoaHoc.SelectedIndex = -1;
            radOnline.Checked = true;
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;
            dtpNgaySinh.Value = DateTime.Today;
            chkNhanEmail.Checked = false;
            CapNhatTongTien();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSoDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                txtHoTen.Focus();
                return;
            }

            if (soDienThoai == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                txtSoDienThoai.Focus();
                return;
            }

            if (cboKhoaHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học.");
                cboKhoaHoc.Focus();
                return;
            }
            int soThang = (int)numSoThang.Value;
            int tongTien = LayHocPhiMotThang() * soThang;
            string hinhThuc;
            if (radOnline.Checked)
            {
                hinhThuc = "Online";
            }
            else
            {
                hinhThuc = "Trực tiếp";
            }

            string nhanEmail;
            if (chkNhanEmail.Checked)
            {
                nhanEmail = "Có";
            }
            else
            {
                nhanEmail = "Không";
            }

            string phieuDangKy =
                $"Họ tên: {hoTen}\n" +
                $"Số điện thoại: {soDienThoai}\n" +
                $"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}\n" +
                $"Khóa học: {cboKhoaHoc.Text}\n" +
                $"Hình thức học: {hinhThuc}\n" +
                $"Số tháng: {soThang}\n" +
                $"Tổng tiền: {tongTien:N0} VNĐ\n" +
                $"Nhận email thông báo: {nhanEmail}";

            MessageBox.Show(
                phieuDangKy,
                "PHIẾU ĐĂNG KÝ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();

            dtpNgaySinh.Value = DateTime.Today;
            chkNhanEmail.Checked = false;
            cboKhoaHoc.SelectedIndex = -1;
            radOnline.Checked = true;
            numSoThang.Value = 1;
            CapNhatTongTien();
            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ketqua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
