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
    public partial class FormGioHang : Form
    {
        public FormGioHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSP = dgvDSSanPham
                .Rows[e.RowIndex].Cells["MaSP"]
                .Value.ToString();

            txtMaSanPham.Text = maSP;

        }

        private void FormGioHang_Load(object sender, EventArgs e)
        {
            // tải danh sách sản phẩm
            string sql =
           String.Format(@"Select * from Sanpham");
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter(sql, conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSSanPham.DataSource = dtKhachHang;
            // tai danh sach san pham dsa chon
            if (GioHang.DanhSachSanPham != null)
                dgvChiTietHoaDon.DataSource
                    = GioHang.DanhSachSanPham.ToList();


        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                int maSP;
                int soLuong;
                if (int.TryParse
                    (txtMaSanPham.Text, out maSP) == false)
                {
                    throw new Exception("Bạn Chưa Chọn Sản Phẩm");
                }
                if (int.TryParse
                    (txtSoLuong.Text, out soLuong) == false)
                {
                    throw new Exception("Bạn Chưa Nhập Số Lượng");
                }
                // 
                SanPham sp = new SanPham();
                SanPham spTim = sp.SanPhamById(maSP);
                GioHang gh = new GioHang();
                gh.ThemGiohang(spTim, soLuong);

                dgvChiTietHoaDon.DataSource
                    = GioHang.DanhSachSanPham.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
