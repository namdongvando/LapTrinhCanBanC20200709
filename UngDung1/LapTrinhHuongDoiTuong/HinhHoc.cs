using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhHuongDoiTuong
{
    class HinhHoc
    {
        public static double TinhDienTichHinhCN(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double TinhDienTichHinhTron(double d)
        {
            return Math.Pow(d / 2, 2) * Math.PI;
        }

        public static double TinhDienTichHinhVuong(double canh)
        {
            return canh * canh;
        }
    }
}
