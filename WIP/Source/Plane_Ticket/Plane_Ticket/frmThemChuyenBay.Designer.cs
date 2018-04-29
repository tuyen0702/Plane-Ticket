namespace Plane_Ticket
{
    partial class frmThemChuyenBay
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtThoiGianKhoiHanh = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaMayBay = new System.Windows.Forms.ComboBox();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.cboMaTuyenBay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 265);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 143);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 17);
            this.label24.TabIndex = 30;
            this.label24.Text = "Mã Máy Bay";
            // 
            // txtThoiGianKhoiHanh
            // 
            this.txtThoiGianKhoiHanh.Location = new System.Drawing.Point(182, 172);
            this.txtThoiGianKhoiHanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianKhoiHanh.Name = "txtThoiGianKhoiHanh";
            this.txtThoiGianKhoiHanh.Size = new System.Drawing.Size(307, 22);
            this.txtThoiGianKhoiHanh.TabIndex = 33;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 175);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 17);
            this.label25.TabIndex = 31;
            this.label25.Text = "Thời Gian Khởi Hành";
            // 
            // txtThoiGianKetThuc
            // 
            this.txtThoiGianKetThuc.Location = new System.Drawing.Point(182, 204);
            this.txtThoiGianKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianKetThuc.Name = "txtThoiGianKetThuc";
            this.txtThoiGianKetThuc.Size = new System.Drawing.Size(307, 22);
            this.txtThoiGianKetThuc.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(34, 207);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(131, 17);
            this.label26.TabIndex = 28;
            this.label26.Text = "Thời Gian Kết Thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "THÊM CHUYẾN BAY";
            // 
            // cboMaMayBay
            // 
            this.cboMaMayBay.FormattingEnabled = true;
            this.cboMaMayBay.Location = new System.Drawing.Point(182, 137);
            this.cboMaMayBay.Name = "cboMaMayBay";
            this.cboMaMayBay.Size = new System.Drawing.Size(307, 24);
            this.cboMaMayBay.TabIndex = 36;
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(214, 265);
            this.btnTaoLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(100, 30);
            this.btnTaoLai.TabIndex = 34;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(371, 265);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 105);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "Mã Tuyến Bay";
            // 
            // cboMaTuyenBay
            // 
            this.cboMaTuyenBay.FormattingEnabled = true;
            this.cboMaTuyenBay.Location = new System.Drawing.Point(182, 98);
            this.cboMaTuyenBay.Name = "cboMaTuyenBay";
            this.cboMaTuyenBay.Size = new System.Drawing.Size(307, 24);
            this.cboMaTuyenBay.TabIndex = 36;
            // 
            // frmThemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 325);
            this.Controls.Add(this.cboMaMayBay);
            this.Controls.Add(this.cboMaTuyenBay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtThoiGianKhoiHanh);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtThoiGianKetThuc);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Name = "frmThemChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chuyến bay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtThoiGianKhoiHanh;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtThoiGianKetThuc;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaMayBay;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cboMaTuyenBay;
    }
}