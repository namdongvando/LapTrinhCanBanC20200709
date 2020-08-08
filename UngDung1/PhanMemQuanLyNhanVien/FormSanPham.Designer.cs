namespace PhanMemQuanLyNhanVien
{
    partial class FormSanPham
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoabtnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.dgvDSSamPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSamPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(682, 182);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(393, 20);
            this.txtDonGia.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Đơn Vị Tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(682, 132);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(393, 20);
            this.txtDonViTinh.TabIndex = 35;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1000, 392);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoabtnXoa
            // 
            this.btnXoabtnXoa.Location = new System.Drawing.Point(894, 392);
            this.btnXoabtnXoa.Name = "btnXoabtnXoa";
            this.btnXoabtnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoabtnXoa.TabIndex = 33;
            this.btnXoabtnXoa.Text = "Xóa";
            this.btnXoabtnXoa.UseVisualStyleBackColor = true;
            this.btnXoabtnXoa.Click += new System.EventHandler(this.btnXoabtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(788, 392);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(682, 392);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(682, 82);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(393, 20);
            this.txtTenSanPham.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.White;
            this.txtMaSanPham.Location = new System.Drawing.Point(682, 32);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(393, 20);
            this.txtMaSanPham.TabIndex = 27;
            // 
            // dgvDSSamPham
            // 
            this.dgvDSSamPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSamPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSamPham.Location = new System.Drawing.Point(12, 12);
            this.dgvDSSamPham.Name = "dgvDSSamPham";
            this.dgvDSSamPham.Size = new System.Drawing.Size(646, 403);
            this.dgvDSSamPham.TabIndex = 26;
            this.dgvDSSamPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSamPham_CellContentClick);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoabtnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.dgvDSSamPham);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSamPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoabtnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.DataGridView dgvDSSamPham;
    }
}