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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            this.LoadCbbThanhPho();
            this.LoadDgvKhachHang();
        }

        private void LoadDgvKhachHang()
        {
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter("select * from khachhang", conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSKhachHang.DataSource = dtKhachHang;
        }

        private void LoadCbbThanhPho()
        {
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter("select * from thanhpho", conn);
            DataTable dtThanhPho = new DataTable();
            daKhachHang.Fill(dtThanhPho);
            cbbThanhPho.DataSource = dtThanhPho;
            cbbThanhPho.DisplayMember = "TenThanhPho";
            cbbThanhPho.ValueMember = "MaThanhPho";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormInput();
                string sql = string.Format(@"insert Khachhang
(MaKH,TenCty,DiaChi,MaThanhPho,DienThoai)
Values (N'{0}',N'{1}',N'{2}',{3},N'{4}')",
        txtMaKhacHang.Text,
        txtTenCTY.Text,
        txtDiaChi.Text,
        cbbThanhPho.SelectedValue.ToString()
        , txtDienThoai.Text
    );
                Adapter ad = new Adapter();
                ad.SaveQuery(sql);
                LoadDgvKhachHang();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void clearForm()
        {
            txtTenCTY.Text = "";
            txtMaKhacHang.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
             
        }

        private void CheckFormInput()
        {
            if (txtMaKhacHang.TextLength == 0
                || txtMaKhacHang.TextLength > 7) {
                throw new Exception("Ma Khách Hàng Không Hợp Lệ");
            }
            if ( txtDienThoai.TextLength > 10)
            {
                throw new Exception("SDT Không Hợp Lệ");
            }

        }
    }
}
