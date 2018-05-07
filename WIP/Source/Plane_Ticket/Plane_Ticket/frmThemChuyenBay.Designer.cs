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
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.cboMaTuyenBay = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cboMaMayBay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGianKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaHangVe = new System.Windows.Forms.ComboBox();
            this.txtTongSoGhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwThongTinGheCuaChuyenBay = new System.Windows.Forms.ListView();
            this.colHderMaHangVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHderTenHangVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHderTongSoGhe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemTTGheCuaChuyenBay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(390, 253);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Location = new System.Drawing.Point(183, 223);
            this.txtThoiGianBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(307, 22);
            this.txtThoiGianBay.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(35, 226);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 17);
            this.label26.TabIndex = 28;
            this.label26.Text = "Thời gian bay";
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
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(227, 577);
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
            this.btnThoat.Location = new System.Drawing.Point(384, 577);
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
            this.label27.Location = new System.Drawing.Point(35, 124);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "Mã tuyến bay";
            // 
            // cboMaTuyenBay
            // 
            this.cboMaTuyenBay.FormattingEnabled = true;
            this.cboMaTuyenBay.Location = new System.Drawing.Point(183, 117);
            this.cboMaTuyenBay.Name = "cboMaTuyenBay";
            this.cboMaTuyenBay.Size = new System.Drawing.Size(307, 24);
            this.cboMaTuyenBay.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(35, 194);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 17);
            this.label25.TabIndex = 31;
            this.label25.Text = "Thời gian khởi hành";
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(183, 80);
            this.txtMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.ReadOnly = true;
            this.txtMaChuyenBay.Size = new System.Drawing.Size(307, 22);
            this.txtMaChuyenBay.TabIndex = 33;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(35, 162);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 17);
            this.label24.TabIndex = 30;
            this.label24.Text = "Mã máy bay";
            // 
            // cboMaMayBay
            // 
            this.cboMaMayBay.FormattingEnabled = true;
            this.cboMaMayBay.Location = new System.Drawing.Point(183, 156);
            this.cboMaMayBay.Name = "cboMaMayBay";
            this.cboMaMayBay.Size = new System.Drawing.Size(307, 24);
            this.cboMaMayBay.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã chuyến bay";
            // 
            // txtThoiGianKH
            // 
            this.txtThoiGianKH.Location = new System.Drawing.Point(183, 191);
            this.txtThoiGianKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianKH.Name = "txtThoiGianKH";
            this.txtThoiGianKH.Size = new System.Drawing.Size(307, 22);
            this.txtThoiGianKH.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hạng vé";
            // 
            // cboMaHangVe
            // 
            this.cboMaHangVe.FormattingEnabled = true;
            this.cboMaHangVe.Location = new System.Drawing.Point(183, 313);
            this.cboMaHangVe.Name = "cboMaHangVe";
            this.cboMaHangVe.Size = new System.Drawing.Size(155, 24);
            this.cboMaHangVe.TabIndex = 36;
            // 
            // txtTongSoGhe
            // 
            this.txtTongSoGhe.Location = new System.Drawing.Point(183, 356);
            this.txtTongSoGhe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongSoGhe.Name = "txtTongSoGhe";
            this.txtTongSoGhe.Size = new System.Drawing.Size(155, 22);
            this.txtTongSoGhe.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số ghế của hạng vé";
            // 
            // lvwThongTinGheCuaChuyenBay
            // 
            this.lvwThongTinGheCuaChuyenBay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHderMaHangVe,
            this.colHderTenHangVe,
            this.colHderTongSoGhe});
            this.lvwThongTinGheCuaChuyenBay.Location = new System.Drawing.Point(38, 396);
            this.lvwThongTinGheCuaChuyenBay.Name = "lvwThongTinGheCuaChuyenBay";
            this.lvwThongTinGheCuaChuyenBay.Size = new System.Drawing.Size(495, 171);
            this.lvwThongTinGheCuaChuyenBay.TabIndex = 37;
            this.lvwThongTinGheCuaChuyenBay.UseCompatibleStateImageBehavior = false;
            this.lvwThongTinGheCuaChuyenBay.View = System.Windows.Forms.View.Details;
            // 
            // colHderMaHangVe
            // 
            this.colHderMaHangVe.Text = "Mã hạng vé";
            this.colHderMaHangVe.Width = 146;
            // 
            // colHderTenHangVe
            // 
            this.colHderTenHangVe.Text = "Tên hạng vé";
            this.colHderTenHangVe.Width = 165;
            // 
            // colHderTongSoGhe
            // 
            this.colHderTongSoGhe.Text = "Tổng số ghế";
            this.colHderTongSoGhe.Width = 179;
            // 
            // btnThemTTGheCuaChuyenBay
            // 
            this.btnThemTTGheCuaChuyenBay.Location = new System.Drawing.Point(390, 348);
            this.btnThemTTGheCuaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTTGheCuaChuyenBay.Name = "btnThemTTGheCuaChuyenBay";
            this.btnThemTTGheCuaChuyenBay.Size = new System.Drawing.Size(100, 30);
            this.btnThemTTGheCuaChuyenBay.TabIndex = 34;
            this.btnThemTTGheCuaChuyenBay.Text = "Thêm";
            this.btnThemTTGheCuaChuyenBay.UseVisualStyleBackColor = true;
            this.btnThemTTGheCuaChuyenBay.Click += new System.EventHandler(this.btnThemTTGheCuaChuyenBay_Click);
            // 
            // frmThemChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 631);
            this.Controls.Add(this.lvwThongTinGheCuaChuyenBay);
            this.Controls.Add(this.cboMaMayBay);
            this.Controls.Add(this.cboMaHangVe);
            this.Controls.Add(this.cboMaTuyenBay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.btnThemTTGheCuaChuyenBay);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtMaChuyenBay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtTongSoGhe);
            this.Controls.Add(this.txtThoiGianKH);
            this.Controls.Add(this.txtThoiGianBay);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label27);
            this.Name = "frmThemChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chuyến bay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cboMaTuyenBay;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboMaMayBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoiGianKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaHangVe;
        private System.Windows.Forms.TextBox txtTongSoGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwThongTinGheCuaChuyenBay;
        private System.Windows.Forms.ColumnHeader colHderMaHangVe;
        private System.Windows.Forms.ColumnHeader colHderTenHangVe;
        private System.Windows.Forms.ColumnHeader colHderTongSoGhe;
        private System.Windows.Forms.Button btnThemTTGheCuaChuyenBay;
    }
}