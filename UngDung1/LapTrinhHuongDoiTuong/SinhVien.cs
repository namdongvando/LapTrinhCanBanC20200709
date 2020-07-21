using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong
{
    class SinhVien
    {
        public static List<SinhVien> DanhSachSinhVien;

        public string MaSV { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public SinhVien()
        {
            if (DanhSachSinhVien == null)
            {
                DanhSachSinhVien = new List<SinhVien>();
            }
        }

        private int TinhTuoi() {
            return DateTime.Now.Year - NgaySinh.Year;
        }

        public void ThemSinhVien(SinhVien sinhVien)
        {
            DanhSachSinhVien.Add(sinhVien);
        }

        public void ThemSinhVien()
        {
            DanhSachSinhVien.Add(this);
        }

        public string ThongTinSinhVien()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}",
                MaSV, Ten, NgaySinh, DiaChi,TinhTuoi()
                );
        }
    }
}
