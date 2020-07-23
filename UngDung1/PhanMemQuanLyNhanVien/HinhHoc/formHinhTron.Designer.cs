namespace PhanMemQuanLyNhanVien.HinhHoc
{
    partial class formHinhTron
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(296, 61);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(100, 20);
            this.txtDienTich.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diện Tích";
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(296, 25);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(100, 20);
            this.txtChuVi.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chu Vi";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(182, 120);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 9;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(91, 28);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(100, 20);
            this.txtBanKinh.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bán Kính";
            // 
            // formHinhTron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 192);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.label1);
            this.Name = "formHinhTron";
            this.Text = "formHinhTron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Label label1;
    }
}