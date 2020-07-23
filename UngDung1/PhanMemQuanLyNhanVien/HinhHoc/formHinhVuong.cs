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
    public partial class formHinhVuong : Form
    {
        public formHinhVuong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double canh;
                if (double.TryParse(txtCanh.Text, out canh) == false)
                {
                    throw new Exception("Dữ Liệu Không Hợp Lệ");
                }
                HinhVuong hV = new HinhVuong(canh);

                txtChuVi.Text = hV.TinhChuVi().ToString();
                txtDienTich.Text = hV.TinhDienTich().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }



        }
    }
}
