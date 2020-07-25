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
    public partial class FormDanhSachNhanVien : Form
    {
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            dgvDSNhanVien.DataSource = nv.GetDSNhanVien().ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // lay thông tin nhan vien tu form
            // them cái gì?


           
            try
            {
                NhanVien nvTuFormThem = GetInputForm();
                // them vao đâu?
                nvTuFormThem.ThemNhanVien(nvTuFormThem);
                // cập nhật lai danh sach nhân vien tren form
                dgvDSNhanVien.DataSource = typeof(List<NhanVien>);
                dgvDSNhanVien.DataSource = nvTuFormThem.GetDSNhanVien();
                MessageBox.Show("Thêm Thành Công");
            }
            catch (Exception ex)
            {
                // các ban bổ sung thêm
                MessageBox.Show(ex.Message);
            }


        }

        private void CapNhatDanhSachNhanVien(NhanVien nv)
        {
            dgvDSNhanVien.Rows.Add(nv);
        }

        private NhanVien GetInputForm()
        {
            NhanVien nv = new NhanVien();
            if (txtMaNhanVien.Text.Length == 0) {
                throw new Exception("Bạn Chưa Nhập Mã Nhân Viên") ;
            }
            if (txtTenNhanVien.Text.Length == 0)
            {
                throw new Exception("Bạn Chưa Nhập Tên Nhân Viên");
            }
            DateTime ngaySinh;
            if (DateTime.TryParse(dtpNgaySinh.Value.ToString(), out ngaySinh)==false) {
                throw new Exception("Ngày Sinh Không Hợp Lệ");
            }
            // tất cả thông tin đã ok
            nv.MaNhanVien = txtMaNhanVien.Text;
            nv.HoTen = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.SDT = txtSDT.Text;
            nv.NgaySinh = ngaySinh;
            return nv;
        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaNV = 
                dgvDSNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(MaNV);
        }
    }
}
