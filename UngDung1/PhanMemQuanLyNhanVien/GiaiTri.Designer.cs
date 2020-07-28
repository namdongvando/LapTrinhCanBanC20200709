namespace PhanMemQuanLyNhanVien
{
    partial class GiaiTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaiTri));
            this.ptbKhungLong = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptbCanhBuom = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbKhungLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanhBuom)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbKhungLong
            // 
            this.ptbKhungLong.Image = ((System.Drawing.Image)(resources.GetObject("ptbKhungLong.Image")));
            this.ptbKhungLong.Location = new System.Drawing.Point(57, 202);
            this.ptbKhungLong.Name = "ptbKhungLong";
            this.ptbKhungLong.Size = new System.Drawing.Size(70, 72);
            this.ptbKhungLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKhungLong.TabIndex = 0;
            this.ptbKhungLong.TabStop = false;
            this.ptbKhungLong.Click += new System.EventHandler(this.ptbKhungLong_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptbCanhBuom
            // 
            this.ptbCanhBuom.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbCanhBuom.ErrorImage")));
            this.ptbCanhBuom.Image = ((System.Drawing.Image)(resources.GetObject("ptbCanhBuom.Image")));
            this.ptbCanhBuom.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbCanhBuom.InitialImage")));
            this.ptbCanhBuom.Location = new System.Drawing.Point(67, 66);
            this.ptbCanhBuom.Name = "ptbCanhBuom";
            this.ptbCanhBuom.Size = new System.Drawing.Size(27, 26);
            this.ptbCanhBuom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCanhBuom.TabIndex = 1;
            this.ptbCanhBuom.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GiaiTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbCanhBuom);
            this.Controls.Add(this.ptbKhungLong);
            this.Name = "GiaiTri";
            this.Text = "GiaiTri";
            this.Load += new System.EventHandler(this.GiaiTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbKhungLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanhBuom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbKhungLong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptbCanhBuom;
        private System.Windows.Forms.Timer timer2;
    }
}