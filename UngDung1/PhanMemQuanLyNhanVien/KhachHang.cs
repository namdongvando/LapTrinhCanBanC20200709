using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{
    class KhachHang
    {
        static KhachHang ChonKhachHangChoHoaDon;

        public string MaKH { get; set; }
        public string TenCty { get; set; }
        /// <summary>
        /// luu lai thông tin khách hàng được chon cho hóa đơn
        /// </summary>
        /// <param name="kh"></param>
        public static void SetChonKhachHangChoHoaDon
            (KhachHang kh) {
            ChonKhachHangChoHoaDon = kh;
        }
        public static KhachHang GetChonKhachHangChoHoaDon()
        {
            if (ChonKhachHangChoHoaDon ==null) {
                return new KhachHang();
            }
            return ChonKhachHangChoHoaDon;
        }

    }
}
