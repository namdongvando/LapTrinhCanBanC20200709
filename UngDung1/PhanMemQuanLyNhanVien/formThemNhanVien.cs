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
    public partial class formThemNhanVien : Form
    {
        public formThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                NhanVien nvTuFormThem = GetInputForm();
                // them vao đâu?
                bool kt = nvTuFormThem.ThemNhanVien(nvTuFormThem);
                if (kt == true) {
                    MessageBox.Show("Thêm Thành Công");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Mã nhân viên đã tồn tại");

            }
            catch (Exception ex)
            {
                // các ban bổ sung thêm
                MessageBox.Show(ex.Message);
            }

        }

        private NhanVien GetInputForm()
        {
            NhanVien nv = new NhanVien();
            if (txtMaNhanVien.Text.Length == 0)
            {
                throw new Exception("Bạn Chưa Nhập Mã Nhân Viên");
            }
            if (txtTenNhanVien.Text.Length == 0)
            {
                throw new Exception("Bạn Chưa Nhập Tên Nhân Viên");
            }
            DateTime ngaySinh;
            if (DateTime.TryParse(dtpNgaySinh.Value.ToString(), out ngaySinh) == false)
            {
                throw new Exception("Ngày Sinh Không Hợp Lệ");
            }
            // tất cả thông tin đã ok
            nv.MaNV = txtMaNhanVien.Text;
            nv.Ho = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Ten = txtEmail.Text;
            nv.DienThoai = txtSDT.Text;
            nv.NgayNV = ngaySinh;
            return nv;
        }
    }
}
