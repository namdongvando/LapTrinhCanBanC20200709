namespace PhanMemQuanLyNhanVien
{
    partial class FormKhachHang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoabtnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenCTY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhacHang = new System.Windows.Forms.TextBox();
            this.dgvDSKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cbbThanhPho = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1261, 608);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoabtnXoa
            // 
            this.btnXoabtnXoa.Location = new System.Drawing.Point(1155, 608);
            this.btnXoabtnXoa.Name = "btnXoabtnXoa";
            this.btnXoabtnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoabtnXoa.TabIndex = 17;
            this.btnXoabtnXoa.Text = "Xóa";
            this.btnXoabtnXoa.UseVisualStyleBackColor = true;
            this.btnXoabtnXoa.Click += new System.EventHandler(this.btnXoabtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1049, 608);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(943, 608);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên CTY";
            // 
            // txtTenCTY
            // 
            this.txtTenCTY.Location = new System.Drawing.Point(926, 84);
            this.txtTenCTY.Name = "txtTenCTY";
            this.txtTenCTY.Size = new System.Drawing.Size(393, 20);
            this.txtTenCTY.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(927, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaKhacHang
            // 
            this.txtMaKhacHang.Location = new System.Drawing.Point(926, 29);
            this.txtMaKhacHang.Name = "txtMaKhacHang";
            this.txtMaKhacHang.Size = new System.Drawing.Size(393, 20);
            this.txtMaKhacHang.TabIndex = 11;
            // 
            // dgvDSKhachHang
            // 
            this.dgvDSKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhachHang.Location = new System.Drawing.Point(12, 12);
            this.dgvDSKhachHang.Name = "dgvDSKhachHang";
            this.dgvDSKhachHang.Size = new System.Drawing.Size(873, 619);
            this.dgvDSKhachHang.TabIndex = 10;
            this.dgvDSKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhachHang_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(923, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(926, 131);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(393, 20);
            this.txtDiaChi.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Thành Phố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Điện Thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(926, 227);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(393, 20);
            this.txtDienThoai.TabIndex = 23;
            // 
            // cbbThanhPho
            // 
            this.cbbThanhPho.FormattingEnabled = true;
            this.cbbThanhPho.Location = new System.Drawing.Point(926, 180);
            this.cbbThanhPho.Name = "cbbThanhPho";
            this.cbbThanhPho.Size = new System.Drawing.Size(393, 21);
            this.cbbThanhPho.TabIndex = 25;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 643);
            this.Controls.Add(this.cbbThanhPho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoabtnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenCTY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKhacHang);
            this.Controls.Add(this.dgvDSKhachHang);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoabtnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCTY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhacHang;
        private System.Windows.Forms.DataGridView dgvDSKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.ComboBox cbbThanhPho;
    }
}