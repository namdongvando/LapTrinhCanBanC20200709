using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{
    class NhanVien : Adapter
    {
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public bool Nu { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayNV { get; set; }


        public NhanVien(string maNV, string ho, string ten, bool nu, string diaChi, string dienThoai, DateTime ngayNV)
        {
            MaNV = maNV;
            Ho = ho;
            Ten = ten;
            Nu = nu;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            NgayNV = ngayNV;
        }

        public NhanVien()
        {

        }

        public List<NhanVien> DSNhanVien()
        {
            string sql = "select * from Nhanvien";
            SqlDataReader dataReader = RunQuery(sql);
            List<NhanVien> lnv = new List<NhanVien>();
            while (dataReader.Read())
            {
                NhanVien nv = new NhanVien()
                {
                    MaNV = dataReader.GetValue(0).ToString(),
                    Ho = dataReader.GetValue(1).ToString(),
                    Ten = dataReader.GetValue(2).ToString(),
                    Nu = bool.Parse(dataReader.GetValue(3).ToString()),
                    NgayNV = new DateTime(),
                    DiaChi = dataReader.GetValue(5).ToString(),
                    DienThoai = dataReader.GetValue(6).ToString()
                };
                DateTime ngayNV = new DateTime();
                DateTime.TryParse(dataReader.GetValue(4).ToString(), out ngayNV);
                nv.NgayNV = ngayNV;
                lnv.Add(nv);
            }
            return lnv;
        }

        public List<NhanVien> GetDSNhanVien()
        {
            List<NhanVien> lnv = new List<NhanVien>();
            lnv = DSNhanVien();
            return lnv;
        }

        public bool ThemNhanVien(NhanVien nvTuFormThem)
        {
            string sql = String.Format(@"INSERT Nhanvien ( Ho, Ten, Nu, NgayNV, DiaChi, DienThoai) 
VALUES ( N'{0}', N'{1}', {2}, CAST(N'{3}' AS Date), N'{4}', N'{5}')", nvTuFormThem.Ho,
nvTuFormThem.Ten,
nvTuFormThem.Nu == true ? 1 : 0,
nvTuFormThem.NgayNV.ToString(),
nvTuFormThem.DiaChi,
nvTuFormThem.DienThoai);
            return SaveQuery(sql);
        }

        public List<NhanVien> NhanViens()
        {

            return new List<NhanVien>();
        }

        public NhanVien GetNVById(string maNV)
        {
            string sql = String.Format(@"select * from Nhanvien where MaNV = '{0}'", maNV);
            SqlDataReader dataReader = RunQuery(sql);
            dataReader.Read();
            NhanVien nv = new NhanVien()
            {
                MaNV = dataReader.GetValue(0).ToString(),
                Ho = dataReader.GetValue(1).ToString(),
                Ten = dataReader.GetValue(2).ToString(),
                Nu = bool.Parse(dataReader.GetValue(3).ToString()),
                NgayNV = new DateTime(),
                DiaChi = dataReader.GetValue(5).ToString(),
                DienThoai = dataReader.GetValue(6).ToString()
            };
            return nv;
        }

        public void SuaNhanVien(NhanVien nvTuFormThem)
        {

        }

        public void XoaNhanVien(string text)
        {

        }
    }
}
