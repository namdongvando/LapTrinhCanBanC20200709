using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien.HinhHoc
{
    public partial class formHinhTron : Form
    {
        public formHinhTron()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double banKinh;
                if (double.TryParse(txtBanKinh.Text, out banKinh) == false)
                {
                    throw new Exception("Dữ liệu nhập không hợp lệ");
                }
                HinhHoc ht = new HinhTron(banKinh);
                txtChuVi.Text = ht.TinhChuVi().ToString();
                txtDienTich.Text = ht.TinhDienTich().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
