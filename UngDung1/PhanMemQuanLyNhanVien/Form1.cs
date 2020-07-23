using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQuanLyNhanVien.HinhHoc;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PhanMemQuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Form fDangNhap = new formDangNhap();
            DialogResult kt = fDangNhap.ShowDialog();
            if (kt == DialogResult.OK)
            {
                InitializeComponent();
            }
            else {
                this.Close();
            }
            
             
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kt=  MessageBox.Show("Bạn có muốn thoát không?",
                "Thông Báo"
                ,MessageBoxButtons.YesNoCancel
                ,MessageBoxIcon.Warning
                );
            if (kt != DialogResult.Yes) {
                e.Cancel = true;  
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            Form fThemNhanVien = new formThemNhanVien();
            fThemNhanVien.Show();
        }

        private void hinhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fHinhVuong = new formHinhVuong();
            fHinhVuong.Show();
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fHinhVuong = new formHinhTron();
            fHinhVuong.Show();
        }
    }
}
