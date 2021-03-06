﻿namespace PhanMemQuanLyNhanVien
{
    partial class FormDanhSachNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngayNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHDDataSet = new PhanMemQuanLyNhanVien.QLHDDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.qLHDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new PhanMemQuanLyNhanVien.QLHDDataSetTableAdapters.NhanvienTableAdapter();
            this.cbxNu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHDDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AutoGenerateColumns = false;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.nuDataGridViewCheckBoxColumn,
            this.ngayNVDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn});
            this.dgvDSNhanVien.DataSource = this.nhanvienBindingSource;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(272, 78);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.Size = new System.Drawing.Size(516, 360);
            this.dgvDSNhanVien.TabIndex = 0;
            this.dgvDSNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNhanVien_CellContentClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoDataGridViewTextBoxColumn
            // 
            this.hoDataGridViewTextBoxColumn.DataPropertyName = "Ho";
            this.hoDataGridViewTextBoxColumn.HeaderText = "Ho";
            this.hoDataGridViewTextBoxColumn.Name = "hoDataGridViewTextBoxColumn";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // nuDataGridViewCheckBoxColumn
            // 
            this.nuDataGridViewCheckBoxColumn.DataPropertyName = "Nu";
            this.nuDataGridViewCheckBoxColumn.HeaderText = "Nu";
            this.nuDataGridViewCheckBoxColumn.Name = "nuDataGridViewCheckBoxColumn";
            // 
            // ngayNVDataGridViewTextBoxColumn
            // 
            this.ngayNVDataGridViewTextBoxColumn.DataPropertyName = "NgayNV";
            this.ngayNVDataGridViewTextBoxColumn.HeaderText = "NgayNV";
            this.ngayNVDataGridViewTextBoxColumn.Name = "ngayNVDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "Nhanvien";
            this.nhanvienBindingSource.DataSource = this.qLHDDataSet;
            // 
            // qLHDDataSet
            // 
            this.qLHDDataSet.DataSetName = "QLHDDataSet";
            this.qLHDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(6, 36);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(226, 20);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 331);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxNu);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 360);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Nhân Viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(6, 210);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(226, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(164, 331);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(83, 331);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày Sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(6, 249);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(226, 42);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DiaChi";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(6, 168);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(226, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(6, 78);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(226, 20);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ ";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Location = new System.Drawing.Point(753, 42);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(35, 30);
            this.btnThemNhanVien.TabIndex = 13;
            this.btnThemNhanVien.Text = "+";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // qLHDDataSetBindingSource
            // 
            this.qLHDDataSetBindingSource.DataSource = this.qLHDDataSet;
            this.qLHDDataSetBindingSource.Position = 0;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // cbxNu
            // 
            this.cbxNu.AutoSize = true;
            this.cbxNu.Location = new System.Drawing.Point(6, 297);
            this.cbxNu.Name = "cbxNu";
            this.cbxNu.Size = new System.Drawing.Size(40, 17);
            this.cbxNu.TabIndex = 13;
            this.cbxNu.Text = "Nữ";
            this.cbxNu.UseVisualStyleBackColor = true;
            // 
            // FormDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSNhanVien);
            this.Name = "FormDanhSachNhanVien";
            this.Text = "FormDanhSachNhanVien";
            this.Load += new System.EventHandler(this.FormDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHDDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.BindingSource qLHDDataSetBindingSource;
        private QLHDDataSet qLHDDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private QLHDDataSetTableAdapters.NhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox cbxNu;
    }
}