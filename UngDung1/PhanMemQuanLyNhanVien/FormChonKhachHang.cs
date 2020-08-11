using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    public partial class FormChonKhachHang : Form
    {
        public FormChonKhachHang()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength >= 3) {
                string sql = String.Format(@"select * from Khachhang 
where MaKH like '%{0}%'
or TenCty like '%{0}%'
or DienThoai like '%{0}%'",txtTimKiem.Text);
                SqlConnection conn = new SqlConnection(Adapter.ConnStr);
                SqlDataAdapter daKhachHang =
                    new SqlDataAdapter(sql, conn);
                DataTable dtKhachHang = new DataTable();
                daKhachHang.Fill(dtKhachHang);
                dgvDSKhachHang.DataSource = dtKhachHang;
                
            }
        }
    }
}
