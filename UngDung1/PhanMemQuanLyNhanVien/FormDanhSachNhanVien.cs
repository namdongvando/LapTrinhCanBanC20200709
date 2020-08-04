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
            // TODO: This line of code loads data into the 'qLHDDataSet.Nhanvien' table. You can move, or remove it, as needed.
            //this.nhanvienTableAdapter.Fill(this.qLHDDataSet.Nhanvien);
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
                bool kt = nvTuFormThem.ThemNhanVien(nvTuFormThem);
                // cập nhật lai danh sach nhân vien tren form
                //dgvDSNhanVien.DataSource = typeof(List<NhanVien>);
                dgvDSNhanVien.DataSource = nvTuFormThem.GetDSNhanVien().ToList();
                if (kt == true)
                    MessageBox.Show("Thêm Thành Công");
                else
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                SetInputForm(new NhanVien());

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
            //if (txtMaNhanVien.Text.Length == 0)
            //{
            //    throw new Exception("Bạn Chưa Nhập Mã Nhân Viên");
            //}
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
            nv.Nu = cbxNu.Checked;
            nv.MaNV = txtMaNhanVien.Text;
            nv.Ho = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Ten = txtEmail.Text;
            nv.DienThoai = txtSDT.Text;
            nv.NgayNV = ngaySinh;
            return nv;
        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaNV =
                dgvDSNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(MaNV);
            NhanVien nv = new NhanVien();
            NhanVien nvById = nv.GetNVById(MaNV);
            SetInputForm(nvById);
            Form fSuaNhanVien = new FormSuaNhanVien(nvById.MaNV);
            var kt = fSuaNhanVien.ShowDialog();
            if (kt == DialogResult.OK) {
                dgvDSNhanVien.DataSource = 
                    nv.GetDSNhanVien().ToList();
            }


        }

        private void SetInputForm(NhanVien nvById)
        {
            txtMaNhanVien.Text = nvById.MaNV;
            txtTenNhanVien.Text = nvById.Ho;
            txtDiaChi.Text = nvById.DiaChi;
            txtEmail.Text = nvById.Ten;
            txtSDT.Text = nvById.DienThoai;
            if (nvById.NgayNV != new DateTime())
                dtpNgaySinh.Value = nvById.NgayNV;
            else
                dtpNgaySinh.Value = DateTime.Today;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nvTuFormThem = GetInputForm();
                // sua vao đâu?
                nvTuFormThem.SuaNhanVien(nvTuFormThem);
                // cập nhật lai danh sach nhân vien tren form
                //dgvDSNhanVien.DataSource = typeof(List<NhanVien>);
                dgvDSNhanVien.DataSource = nvTuFormThem.GetDSNhanVien().ToList();
                MessageBox.Show("Sửa Thành Công");
                SetInputForm(new NhanVien());
            }
            catch (Exception ex)
            {
                // các ban bổ sung thêm
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (hoi != DialogResult.Yes)
            {
                return;
            }
            // da bam vao nut yes
            NhanVien nv = new NhanVien();
            // xóa nhân viên theo mã trong textbox txtMaNhanVien
            nv.XoaNhanVien(txtMaNhanVien.Text);
            MessageBox.Show("Đã Xóa Thành Công");
            // cap nhật danh sách nhan vien
            dgvDSNhanVien.DataSource =
                nv.GetDSNhanVien().ToList();
            SetInputForm(new NhanVien());
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            Form fThemNhanVien = new formThemNhanVien();
            var kt = fThemNhanVien.ShowDialog();
            // them thành công thì cập nhật danh sách nhan vien
            if (kt == DialogResult.OK)
            {
                NhanVien nv = new NhanVien();
                dgvDSNhanVien.DataSource = nv.GetDSNhanVien().ToList();
            }

        }
    }
}
