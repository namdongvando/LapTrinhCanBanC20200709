﻿using System;
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
    public partial class FormSuaNhanVien : Form
    {
        private static String nvById;

        public FormSuaNhanVien()
        {
            InitializeComponent();
        }

        public FormSuaNhanVien(string maNV)
        {
            InitializeComponent();
            nvById = maNV;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nvTuFormThem = GetInputForm();
                nvTuFormThem.SuaNhanVien(nvTuFormThem);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Sửa Thành Công");
                this.Close();
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
            nv.MaNV= txtMaNhanVien.Text;
            nv.Ho = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Ten = txtEmail.Text;
            nv.DienThoai = txtSDT.Text;
            nv.NgayNV = ngaySinh;
            return nv;
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

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            SetInputForm(nv.GetNVById(nvById));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
