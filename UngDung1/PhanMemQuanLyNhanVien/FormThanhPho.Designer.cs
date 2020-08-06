namespace PhanMemQuanLyNhanVien
{
    partial class FormThanhPho
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
            this.dgvDSThanhPho = new System.Windows.Forms.DataGridView();
            this.txtMaThanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoabtnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhPho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSThanhPho
            // 
            this.dgvDSThanhPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhPho.Location = new System.Drawing.Point(12, 12);
            this.dgvDSThanhPho.Name = "dgvDSThanhPho";
            this.dgvDSThanhPho.Size = new System.Drawing.Size(433, 428);
            this.dgvDSThanhPho.TabIndex = 0;
            this.dgvDSThanhPho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSThanhPho_CellContentClick);
            // 
            // txtMaThanhPho
            // 
            this.txtMaThanhPho.Location = new System.Drawing.Point(470, 88);
            this.txtMaThanhPho.Name = "txtMaThanhPho";
            this.txtMaThanhPho.ReadOnly = true;
            this.txtMaThanhPho.Size = new System.Drawing.Size(304, 20);
            this.txtMaThanhPho.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Thành Phố";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Thành Phố";
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(470, 143);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(304, 20);
            this.txtTenThanhPho.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(470, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(584, 186);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoabtnXoa
            // 
            this.btnXoabtnXoa.Location = new System.Drawing.Point(698, 186);
            this.btnXoabtnXoa.Name = "btnXoabtnXoa";
            this.btnXoabtnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoabtnXoa.TabIndex = 8;
            this.btnXoabtnXoa.Text = "Xóa";
            this.btnXoabtnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(721, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoabtnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenThanhPho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaThanhPho);
            this.Controls.Add(this.dgvDSThanhPho);
            this.Name = "FormThanhPho";
            this.Text = "FormThanhPho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThanhPho_FormClosing);
            this.Load += new System.EventHandler(this.FormThanhPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhPho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSThanhPho;
        private System.Windows.Forms.TextBox txtMaThanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoabtnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}