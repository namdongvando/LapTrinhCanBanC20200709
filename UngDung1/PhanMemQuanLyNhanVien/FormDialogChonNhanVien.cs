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
    public partial class FormDialogChonNhanVien : Form
    {
        public FormDialogChonNhanVien()
        {
            InitializeComponent();
        }

        private void FormDialogChonNhanVien_Load(object sender, EventArgs e)
        {
            string sql =
           String.Format(@"select  
Nhanvien.MaNV,
HoTen = Nhanvien.Ho +' ' + Nhanvien.Ten,
Nhanvien.NgayNV,
Nhanvien.DiaChi,
Nhanvien.DienThoai
  from Nhanvien ");
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter(sql, conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSNhanVien.DataSource = dtKhachHang;
        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var yes = MessageBox.Show("Bạn có muốn chọn nhân viên này không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                );
            if (yes != DialogResult.Yes) {
                return;
            }
            // đồng ý
            string maNV = dgvDSNhanVien.Rows[e.RowIndex]
                .Cells["MaNV"].Value.ToString();
            string hoTen = dgvDSNhanVien.Rows[e.RowIndex]
                .Cells["HoTen"].Value.ToString();
            NhanVienModelView.SetChonNhanVienChoHoaDon(
                new NhanVienModelView() {
                    MaNV = maNV,
                    HoTen = hoTen
                }
                );
            this.DialogResult = DialogResult.OK;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }

        private void TimKiemNhanVien()
        {
            string sql =
           String.Format(@"select  
Nhanvien.MaNV,
HoTen = Nhanvien.Ho +' ' + Nhanvien.Ten,
Nhanvien.NgayNV,
Nhanvien.DiaChi,
Nhanvien.DienThoai
  from Nhanvien
where MaNV like '%{0}%'
or Ten like '%{0}%'
or ho like '%{0}%'
or dienthoai like '%{0}%'", txtTimKiem.Text);
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter(sql, conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSNhanVien.DataSource = dtKhachHang;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemNhanVien();
        }
    }
}
