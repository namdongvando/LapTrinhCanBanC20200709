using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong
{

     
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.Ten = "teo";
            sv.MaSV = "00001";
            sv.NgaySinh = new DateTime(2000, 6, 12);
            sv.DiaChi = "hcm";

            sv.ThemSinhVien();
            sv.ThemSinhVien(
                 new SinhVien()
                 {
                     MaSV = "0003"
                ,
                     Ten = "nguyen van a"
                ,
                     NgaySinh = new DateTime(2020, 03, 06)
                ,
                     DiaChi = "hue"
                 }
                );


            foreach (SinhVien item in SinhVien.DanhSachSinhVien)
            {
                Console.WriteLine(item.ThongTinSinhVien());
                Console.WriteLine(item.Ten);
            }



        }

        private static void SuDungSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.Ten = "teo";
            sv.MaSV = "00001";
            sv.NgaySinh = new DateTime(2000, 6, 12);
            sv.DiaChi = "hcm";

            SinhVien ti = new SinhVien();
            ti.Ten = "ti";
            ti.MaSV = "0002";
            ti.DiaChi = "ha noi";
            ti.NgaySinh = new DateTime(2020, 6, 30);

            SinhVien a = new SinhVien()
            {
                MaSV = "0003"
                ,
                Ten = "nguyen van a"
                ,
                NgaySinh = new DateTime(2020, 03, 06)
                ,
                DiaChi = "hue"
            };

            Console.WriteLine(sv.ThongTinSinhVien());
            Console.WriteLine(ti.ThongTinSinhVien());
            Console.WriteLine(a.ThongTinSinhVien());
        }
    }
}
