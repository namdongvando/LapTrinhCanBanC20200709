using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = new char();
            }
            else {
                txtMatKhau.PasswordChar = '*';
            }
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin"
                && txtMatKhau.Text == "123456") {
                this.DialogResult = DialogResult.OK;
            } else{
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng",
                    "Lỗi Đăng Nhập", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }
    }
}
