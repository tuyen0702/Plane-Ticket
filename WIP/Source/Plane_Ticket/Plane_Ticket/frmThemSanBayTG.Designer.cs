namespace Plane_Ticket
{
    partial class frmThemSanBayTG
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
            this.lvwSanBayTrungGian = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTenSanBay = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtThoiGianNghi = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvwSanBayTrungGian
            // 
            this.lvwSanBayTrungGian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwSanBayTrungGian.Location = new System.Drawing.Point(12, 238);
            this.lvwSanBayTrungGian.Name = "lvwSanBayTrungGian";
            this.lvwSanBayTrungGian.Size = new System.Drawing.Size(501, 162);
            this.lvwSanBayTrungGian.TabIndex = 40;
            this.lvwSanBayTrungGian.UseCompatibleStateImageBehavior = false;
            this.lvwSanBayTrungGian.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sân bay trung gian";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian dừng";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ghi chú";
            this.columnHeader3.Width = 162;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(375, 407);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(218, 407);
            this.btnTaoLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(100, 30);
            this.btnTaoLai.TabIndex = 42;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(59, 407);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTenSanBay
            // 
            this.cboTenSanBay.FormattingEnabled = true;
            this.cboTenSanBay.Location = new System.Drawing.Point(167, 93);
            this.cboTenSanBay.Name = "cboTenSanBay";
            this.cboTenSanBay.Size = new System.Drawing.Size(307, 24);
            this.cboTenSanBay.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 99);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 17);
            this.label24.TabIndex = 44;
            this.label24.Text = "Tên sân bay";
            // 
            // txtThoiGianNghi
            // 
            this.txtThoiGianNghi.Location = new System.Drawing.Point(167, 128);
            this.txtThoiGianNghi.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianNghi.Name = "txtThoiGianNghi";
            this.txtThoiGianNghi.Size = new System.Drawing.Size(307, 22);
            this.txtThoiGianNghi.TabIndex = 46;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 131);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 17);
            this.label25.TabIndex = 45;
            this.label25.Text = "Thời gian nghỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "THÊM SÂN BAY TRUNG GIAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(167, 162);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(307, 22);
            this.txtGhiChu.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mã chuyến bay";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(167, 62);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(307, 24);
            this.cboMaChuyenBay.TabIndex = 47;
            this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            // 
            // frmThemSanBayTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaChuyenBay);
            this.Controls.Add(this.cboTenSanBay);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtThoiGianNghi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvwSanBayTrungGian);
            this.Name = "frmThemSanBayTG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sân bay trung gian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwSanBayTrungGian;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTenSanBay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtThoiGianNghi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
    }
}