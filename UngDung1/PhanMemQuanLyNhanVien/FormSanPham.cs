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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadDgvDsSanPham();
        }

        private void LoadDgvDsSanPham()
        {
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter("select * from sanpham", conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSSamPham.DataSource = dtKhachHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormInput();
                string sql = string.Format(@"insert Sanpham 
(TenSP,DonViTinh,DonGia) 
values(N'{0}',N'{1}', {2})",
         txtTenSanPham.Text,
         txtDonViTinh.Text,
         txtDonGia.Text
    );
                Adapter ad = new Adapter();
                ad.SaveQuery(sql);
                LoadDgvDsSanPham();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearForm()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";


        }

        private void CheckFormInput()
        {
            if (txtTenSanPham.TextLength == 0)
            {
                txtTenSanPham.Focus();
                throw new Exception("Bạn chưa nhập tên sản phẩm");
            }
            if (txtDonViTinh.TextLength > 5)
            {
                txtDonViTinh.Focus();
                throw new Exception("Đơn Vị Tính Không Hợp Lệ");
            }
            double gia;
            if (Double.TryParse(txtDonGia.Text, out gia) == false)
            {
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                throw new Exception("Giá Sản Phẩm Không Hợp Lệ");
            }

        }

        private void dgvDSSamPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ma = dgvDSSamPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Ten = dgvDSSamPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            string DonViTinh = dgvDSSamPham.Rows[e.RowIndex].Cells[2].Value.ToString();
            string DonGia = dgvDSSamPham.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMaSanPham.Text = Ma;
            txtTenSanPham.Text = Ten;
            txtDonViTinh.Text = DonViTinh;
            txtDonGia.Text = DonGia;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormInput();
                string sql = string.Format(@"update Sanpham set
TenSP = N'{0}'
,DonViTinh = N'{1}'
,DonGia = {2}
where MaSP = {3}",
         txtTenSanPham.Text,
         txtDonViTinh.Text,
         txtDonGia.Text
         , txtMaSanPham.Text
    );
                Adapter ad = new Adapter();
                ad.SaveQuery(sql);
                LoadDgvDsSanPham();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoabtnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.TextLength == 0)
                return;
            try
            {
                CheckFormInput();
                string sql = string.Format(@"delete from Sanpham 
where MaSP = {0}",
          txtMaSanPham.Text
    );
                Adapter ad = new Adapter();
                ad.SaveQuery(sql);
                LoadDgvDsSanPham();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
