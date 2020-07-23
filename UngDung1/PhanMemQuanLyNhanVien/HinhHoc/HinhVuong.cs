using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien.HinhHoc
{
    class HinhVuong
    {
        public double Canh { get; set; }

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public double TinhChuVi() {
            return Canh * 4;
        }
        public double TinhDienTich()
        {
            return Canh * Canh;
        }


    }
}
