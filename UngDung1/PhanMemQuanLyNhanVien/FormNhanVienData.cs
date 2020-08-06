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
    public partial class FormNhanVienData : Form
    {
        private string ConnectStr = "Data Source=DESKTOP-M2PUTJR;Initial Catalog=QLHD;Integrated Security=True";

        public FormNhanVienData()
        {
            InitializeComponent();
        }

        private void FormNhanVienData_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConnectStr);
                SqlDataAdapter daKhachHang = new SqlDataAdapter("select * from nhanvien", conn);
                DataTable dtKhachHang = new DataTable();
                daKhachHang.Fill(dtKhachHang);
                dgvDSNhanVien.DataSource = dtKhachHang;

            }
            catch (Exception ex)
            {

            }

        }
    }
}
