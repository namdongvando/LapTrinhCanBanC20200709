using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{
    class NhanVienModelView
    {
        public static NhanVienModelView ChonNhanVienChoHoaDon { get; set; }
        public string MaNV { get; set; }

        public string HoTen { get; set; }

        public static void SetChonNhanVienChoHoaDon(NhanVienModelView nv) {
            ChonNhanVienChoHoaDon = nv;
        }
        public static NhanVienModelView GetChonNhanVienChoHoaDon()
        {
            if (ChonNhanVienChoHoaDon == null)
                return new NhanVienModelView();
            return ChonNhanVienChoHoaDon;
        }


    }
}
