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
    public partial class FormThanhPho : Form
    {
        public FormThanhPho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = String.Format("insert ThanhPho (TenThanhPho) values(N'{0}')",
                txtTenThanhPho.Text);
            Adapter ad = new Adapter();
            // chay query
            ad.SaveQuery(sql);
            // reset danh sach thanh pho
            LoadDanhSachThanhPho();
            // reset form
            txtTenThanhPho.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormThanhPho_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDanhSachThanhPho();

            }
            catch (Exception)
            {

            }

        }

        private void LoadDanhSachThanhPho()
        {
            // lấy danh sach thanh pho
            SqlConnection conn = new SqlConnection(Adapter.ConnStr);
            SqlDataAdapter daKhachHang =
                new SqlDataAdapter("select * from thanhpho", conn);
            DataTable dtKhachHang = new DataTable();
            daKhachHang.Fill(dtKhachHang);
            dgvDSThanhPho.DataSource = dtKhachHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThanhPho_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // kiểm tra du liệu vào
                if (txtMaThanhPho.TextLength == 0)
                    throw new Exception("Mã Thành Phố không để trống.");
                if (txtTenThanhPho.TextLength == 0)
                    throw new Exception("Tên Thành Phố không để trống.");
                // du lieu ok
                string sql = String.Format(@"update ThanhPho set 
TenThanhPho = N'{0}' where MaThanhPho = '{1}'",
                                txtTenThanhPho.Text, txtMaThanhPho.Text);
                Adapter ad = new Adapter();
                // chay query
                ad.SaveQuery(sql);
                // reset danh sach thanh pho
                LoadDanhSachThanhPho();
                // reset form
                txtTenThanhPho.Text = "";
                txtMaThanhPho.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void dgvDSThanhPho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maThanhPho = dgvDSThanhPho.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenThanhPho = dgvDSThanhPho.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaThanhPho.Text = maThanhPho;
            txtTenThanhPho.Text = tenThanhPho;
        }
    }
}
