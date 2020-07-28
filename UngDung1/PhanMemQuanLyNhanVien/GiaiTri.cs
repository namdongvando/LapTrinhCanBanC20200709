using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanVien
{
    public partial class GiaiTri : Form
    {
        static int HuongDiChuyen = 1;


        public GiaiTri()
        {
            InitializeComponent();
        }

        private void GiaiTri_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            ptbKhungLong.Location = new Point(30, 100);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = ptbKhungLong.Location.X;
            int y = ptbKhungLong.Location.Y;

            if (x >= this.Width - ptbKhungLong.Width)
            {
                HuongDiChuyen = -1;
                x = this.Width - ptbKhungLong.Width;
            }

            if (x <= 0)
                HuongDiChuyen = 1;

            if (HuongDiChuyen == 1)
                x++;
            else
                x--;

            ptbKhungLong.Location = new Point(x, y);
        }

        private void ptbKhungLong_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            timer2.Interval = 500;
            int x = ptbCanhBuom.Location.X;
            int y = ptbCanhBuom.Location.Y;
            x += rand.Next(-10, 10);
            y += rand.Next(-10, 10);

            ptbCanhBuom.Location = new Point(x, y);
        }
    }
}
