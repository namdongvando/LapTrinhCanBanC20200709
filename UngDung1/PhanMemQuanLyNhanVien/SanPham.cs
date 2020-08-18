using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{
    class SanPham : Adapter
    {
        public int MaSP { set; get; }
        public string TenSP { set; get; }
        public string DonViTinh { set; get; }
        public decimal DonGia { set; get; }

        public List<SanPham> SanPhams()
        {
            List<SanPham> lsp = new List<SanPham>();
            string sql = @"select * from Sanpham";
            var res = RunQuery(sql);
            while (res.Read())
            {
                lsp.Add(new SanPham()
                {
                    MaSP = int.Parse(res["MaSP"].ToString()),
                    TenSP = res["TenSP"].ToString(),
                    DonViTinh = res["DonViTinh"].ToString(),
                    DonGia =
                    decimal.Parse(res["DonGia"].ToString())
                });
            }
            return lsp;
        }
        public SanPham SanPhamById(int maSP)
        {

            string sql = string.Format(@"select * from Sanpham
where MaSP = {0}", maSP);
            var res = RunQuery(sql);
            res.Read();
            if(res != null)
            return new SanPham()
            {
                MaSP = int.Parse(res["MaSP"].ToString()),
                TenSP = res["TenSP"].ToString(),
                DonViTinh = res["DonViTinh"].ToString(),
                DonGia = decimal.Parse(res["DonGia"].ToString())
            };
            return new SanPham();


        }

    }
}
