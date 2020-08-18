using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{
    class GioHang : SanPham
    {
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }

        public static decimal TongTien { get; set; }

        public static List<GioHang> DanhSachSanPham;

        public void ThemGiohang(SanPham sp,int soLuong) {
            // khoi tao gia tri gio hang 
            GioHang gh = new GioHang()
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                DonGia = sp.DonGia,
                DonViTinh = sp.DonViTinh,
                SoLuong = soLuong,
                ThanhTien= sp.DonGia * soLuong,
            };
            //kiểm tra da co gio hang chua
            if (DanhSachSanPham == null) {
                DanhSachSanPham = new List<GioHang>();
            }
            // tim sản phẩm
            GioHang spTim = 
                DanhSachSanPham
                .FirstOrDefault(i => i.MaSP == sp.MaSP);

            if (spTim == null) {
                DanhSachSanPham.Add(gh);
                return;
            }
            // cập nhật so luong sản phẩm
            spTim.SoLuong += soLuong;
            spTim.ThanhTien = spTim.DonGia * spTim.SoLuong;
            DanhSachSanPham
                .RemoveAll(i => i.MaSP == sp.MaSP);
            DanhSachSanPham.Add(spTim);
        }

        public void XoaGiohang(int MaSanPham = 0) {
            if (MaSanPham == 0) {
                DanhSachSanPham
                    .RemoveAll(i=>i.SoLuong > 0);
                return;
            }
            DanhSachSanPham
            .RemoveAll(i => i.MaSP == MaSanPham);

        }

        public static int TongHoaDon()
        {
            string sql = @"select count(*) as Tong
from Hoadon";
            Adapter ad = new Adapter();
           var res = ad.RunQuery(sql);
            res.Read();
            return int.Parse(res["Tong"].ToString());
        }


    }
}
