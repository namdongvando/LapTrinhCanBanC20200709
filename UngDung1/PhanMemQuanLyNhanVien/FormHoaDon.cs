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
    public partial class FormHoaDon : Form
    {
        static bool isThemHoaDon = true;
        private string maHoaDon;

        public FormHoaDon()
        {
            InitializeComponent();
        }

        public FormHoaDon(string maHoaDon)
        {
            this.maHoaDon = maHoaDon;
            isThemHoaDon = false;
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            // xem hoa don
            if (maHoaDon != null)
            {
                LoadChiTietHoaDon();
            }
            
        }

        private void LoadChiTietHoaDon()
        {
            btnLuuHoaDon.Visible = isThemHoaDon;

            string sql = string.Format(@"select Hoadon.*,
Khachhang.TenCty,
HoTen = Nhanvien.Ho + ' ' + Nhanvien.Ten,
Nhanvien.DienThoai
from Hoadon,Nhanvien,Khachhang
Where Hoadon.MaNV = Nhanvien.MaNV
and Hoadon.MaKH = Khachhang.MaKH
and MaHD = {0}", maHoaDon);
            Adapter ad = new Adapter();
            SqlDataReader chiTietHoaDon = ad.RunQuery(sql);
            chiTietHoaDon.Read();
            txtMaKhachHang.Text = chiTietHoaDon["TenCty"].ToString();
            txtMaNhanVien.Text = chiTietHoaDon["HoTen"].ToString();
            txtMaHoaDon.Text = chiTietHoaDon["MaHD"].ToString();
            dtpNgayGiao.Value = DateTime
                .Parse(chiTietHoaDon["NgayNhanHang"].ToString());
            dtpNgayLap.Value = DateTime
                .Parse(chiTietHoaDon["NgayLapHD"].ToString());

            NoiDungHoaDon();

        }

        private void NoiDungHoaDon()
        {
            dgvChiTietHoaDon.Columns.Add("STT", "Sô Thứ Tự");
            dgvChiTietHoaDon.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            dgvChiTietHoaDon.Columns.Add("SoLuong", "Số Lượng");
            dgvChiTietHoaDon.Columns.Add("DonGia", "Đơn Giá");
            dgvChiTietHoaDon.Columns.Add("ThanhTien", "Thành Tiền");

            string sql = String.Format(@"select a.SoLuong ,b.* 
,ThanhTien =a.SoLuong*b.DonGia 
from Chitiethoadon as a,Sanpham as b
where 
a.MaSP = b.MaSP and
a.MaHD={0}",maHoaDon);
            Adapter ad = new Adapter();
             SqlDataReader noiDungHoaDon = ad.RunQuery(sql);
            double tongTien = 0;
            int stt = 1;
            while (noiDungHoaDon.Read()) {
                tongTien = double.
                    Parse(noiDungHoaDon["ThanhTien"].ToString());
                dgvChiTietHoaDon.Rows.Add(
                    stt,
                    noiDungHoaDon["TenSP"].ToString(),
                    noiDungHoaDon["SoLuong"].ToString(),
                    noiDungHoaDon["DonGia"].ToString(),
                    noiDungHoaDon["ThanhTien"].ToString()
                    );
                stt++;
            }

            //dgvChiTietHoaDon.DataSource = dtKhachHang;
            
        }

        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            Form chonkhachhang = new FormChonKhachHang();
            chonkhachhang.ShowDialog();
        }
    }
}
