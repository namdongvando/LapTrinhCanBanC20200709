using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{
    class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }

        public static List<NhanVien> DSNhanVien;

        public NhanVien(string maNhanVien, string hoTen, string email, string diaChi, string sDT, DateTime ngaySinh)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            Email = email;
            DiaChi = diaChi;
            SDT = sDT;
            NgaySinh = ngaySinh;
            if (DSNhanVien == null) {
                DSNhanVien = new List<NhanVien>();
            }
        }

        public NhanVien()
        {
            if (DSNhanVien == null)
            {
                DSNhanVien = new List<NhanVien>();
            }

        }

        public bool ThemNhanVien(NhanVien nv) {
            // kiem tra có nhan vien trong ds khong?
            if (GetNVById(nv.MaNhanVien) == null) {
                DSNhanVien.Add(nv);
                return true;
            }
            return false;
        }

        public void XoaNhanVien(string MaNhanVien)
        {
            DSNhanVien.RemoveAll(
                item=>item.MaNhanVien==MaNhanVien
                );
        }

        public List<NhanVien> GetDSNhanVien() {
            return DSNhanVien;
        }

        public void KhoiTaoDS() {
            if (DSNhanVien == null)
                DSNhanVien = new List<NhanVien>();
            ThemNhanVien(new NhanVien()
            {
                MaNhanVien = "001",
                HoTen = "Teo",
                DiaChi = "001, as,da,sd,asd,as",
                SDT = "012312312",
                Email= "teonguyen@gmail.com",
                NgaySinh = new DateTime(2000,1,1),
            });
            ThemNhanVien(new NhanVien()
            {
                MaNhanVien = "002",
                HoTen = "Ti",
                DiaChi = "001, as,da,sd,asd,as",
                SDT = "012312312",
                Email = "tinguyen@gmail.com",
                NgaySinh = new DateTime(2000, 1, 1),
            });


        }


        public void SuaNhanVien(NhanVien nv)
        {
            XoaNhanVien(nv.MaNhanVien);
            ThemNhanVien(nv);
        }

        public NhanVien GetNVById(string maNV)
        {
            NhanVien nvTim = 
                DSNhanVien.Find(
                    nv => nv.MaNhanVien == maNV);
            return nvTim;
        }
    }
}
