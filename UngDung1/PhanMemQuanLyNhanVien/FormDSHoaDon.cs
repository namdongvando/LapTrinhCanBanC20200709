using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    public partial class FormDSHoaDon : Form
    {
        public FormDSHoaDon()
        {
            InitializeComponent();
        }

        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            //dgvDSHoaDon.Columns.Add("MaHD", "Mã Hóa Đơn");
            //dgvDSHoaDon.Columns.Add("TenCty", "Tên Công Ty");
            //dgvDSHoaDon.Columns.Add("MaKH", "Mã Khách Hàng");
            //dgvDSHoaDon.Columns.Add("HoTen", "Nhân Viên");
            //dgvDSHoaDon.Columns.Add("DienThoai", "Điện Thoai");

            LoadDSHoaDon();

        }

        private void LoadDSHoaDon()
        {
            // lay danh sách hoa don
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter(@"select Hoadon.MaHD ,
Khachhang.TenCty,Khachhang.MaKH,
HoTen = Nhanvien.Ho + ' ' + Nhanvien.Ten,
Nhanvien.DienThoai
from Hoadon,Nhanvien,Khachhang
Where Hoadon.MaNV = Nhanvien.MaNV
and Hoadon.MaKH = Khachhang.MaKH", conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSHoaDon.DataSource = dtKhachHang;
            dgvDSHoaDon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
            dgvDSHoaDon.Columns["TenCty"].HeaderText = "Tên Công Ty";
            dgvDSHoaDon.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvDSHoaDon.Columns["HoTen"].HeaderText = "Nhân Viên";
            dgvDSHoaDon.Columns["DienThoai"].HeaderText = "Điện Thoai";
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            Form formThemHoaDon = new FormHoaDon();
            formThemHoaDon.Show();


        }

        private void dgvDSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHoaDon = dgvDSHoaDon.Rows[e.RowIndex]
                .Cells["MaHD"].Value.ToString();
            //MessageBox.Show(maHoaDon);
            Form formHoaDon = new FormHoaDon(maHoaDon);
            formHoaDon.Show();

        }
    }
}
