using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien.HinhHoc
{
    class HinhTron : HinhHoc
    {
        public double banKinh { get; set; }

        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public double TinhChuVi()
        {
            return banKinh * 2 * Math.PI;
        }

        public double TinhDienTich()
        {
            return banKinh * banKinh * Math.PI;
        }
    }
}
