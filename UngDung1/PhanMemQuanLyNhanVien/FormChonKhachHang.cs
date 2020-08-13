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
            if (txtTimKiem.TextLength >= 3)
            {
                TimKiemKhachHang();

            }
        }

        private void TimKiemKhachHang()
        {
            string sql = String.Format(@"select * from Khachhang 
where MaKH like '%{0}%'
or TenCty like '%{0}%'
or DienThoai like '%{0}%'", txtTimKiem.Text);
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter(sql, conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSKhachHang.DataSource = dtKhachHang;
        }

        private void FormChonKhachHang_Load(object sender, EventArgs e)
        {
            string sql = 
            String.Format(@"select * from Khachhang", txtTimKiem.Text);
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter(sql, conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSKhachHang.DataSource = dtKhachHang;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength > 0)
            {
                TimKiemKhachHang();
            }


        }

        private void dgvDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string makh = dgvDSKhachHang.Rows[e.RowIndex]
                .Cells["MaKH"].Value.ToString();
            string tencty = dgvDSKhachHang.Rows[e.RowIndex]
                .Cells["TenCty"].Value.ToString();
            string diaChi = dgvDSKhachHang.Rows[e.RowIndex]
                .Cells["DiaChi"].Value.ToString();
            string dienThoai = dgvDSKhachHang.Rows[e.RowIndex]
                .Cells["DienThoai"].Value.ToString();
            txtMaKhacHang.Text = makh;
            txtTenCTY.Text = tencty;
            KhachHang.SetChonKhachHangChoHoaDon(
                new KhachHang()
                {
                    MaKH = makh,
                    TenCty = tencty
                }
             );
            this.DialogResult = DialogResult.OK;
            txtDiaChi.Text = diaChi;
            txtDienThoai.Text = dienThoai;
        }

        private void FormChonKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            KhachHang kh = KhachHang.GetChonKhachHangChoHoaDon();
            if (kh.MaKH == null) {
                MessageBox.Show("Bạn Chưa Chọn Khách Hàng");
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
