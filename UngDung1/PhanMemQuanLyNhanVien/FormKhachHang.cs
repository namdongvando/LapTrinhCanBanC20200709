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
                || txtMaKhacHang.TextLength > 7)
            {
                throw new Exception("Ma Khách Hàng Không Hợp Lệ");
            }
            if (txtDienThoai.TextLength > 10)
            {
                throw new Exception("SDT Không Hợp Lệ");
            }

        }

        private void dgvDSKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKhachHang = dgvDSKhachHang
                .Rows[e.RowIndex]
                .Cells[0].Value.ToString();
            string tenCty = dgvDSKhachHang
                .Rows[e.RowIndex]
                .Cells[1].Value.ToString();
            string diaChi = dgvDSKhachHang
                .Rows[e.RowIndex]
                .Cells[2].Value.ToString();
            int thanhPho = int.Parse(dgvDSKhachHang
                .Rows[e.RowIndex]
                .Cells[3].Value.ToString());
            string dienThoai = dgvDSKhachHang
                .Rows[e.RowIndex]
                .Cells[4].Value.ToString();
            txtMaKhacHang.Text = maKhachHang;
            txtTenCTY.Text = tenCty;
            txtDiaChi.Text = diaChi;
            txtDienThoai.Text = dienThoai;
            cbbThanhPho.SelectedValue = thanhPho;


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormInput();
                string sql = string.Format(@"update Khachhang 
set 
TenCty		=N'{0}'
,DiaChi		=N'{1}'
,MaThanhPho	=N'{2}'
,DienThoai	=N'{3}'
Where MaKH = '{4}'",
        txtTenCTY.Text,
        txtDiaChi.Text,
        cbbThanhPho.SelectedValue.ToString()
        , txtDienThoai.Text
        , txtMaKhacHang.Text
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

        private void btnXoabtnXoa_Click(object sender, EventArgs e)
        {
            //delete from Khachhang where MaKH = 'sefsd'
            try
            {
                var Kt = MessageBox.Show("Bạn có muốn xóa không?",
                    "Thông Báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (Kt != DialogResult.Yes)
                    return;
                if (txtMaKhacHang.TextLength == 0)
                    return;
                string sql =
                    string.Format(@"delete from Khachhang where MaKH = '{0}'",
           txtMaKhacHang.Text);
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
    }
}
