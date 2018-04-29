namespace Plane_Ticket
{
    partial class frmThemTuyenBay
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
            this.label21 = new System.Windows.Forms.Label();
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSanBayDi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSanBayDen = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lvwSanBayTrungGian = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(45, 234);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "Sân bay trung gian";
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Location = new System.Drawing.Point(179, 189);
            this.txtThoiGianBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(321, 22);
            this.txtThoiGianBay.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(45, 194);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 17);
            this.label23.TabIndex = 19;
            this.label23.Text = "Thời gian bay";
            // 
            // txtMaTuyenBay
            // 
            this.txtMaTuyenBay.Location = new System.Drawing.Point(179, 87);
            this.txtMaTuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTuyenBay.Name = "txtMaTuyenBay";
            this.txtMaTuyenBay.Size = new System.Drawing.Size(321, 22);
            this.txtMaTuyenBay.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(45, 92);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Mã tuyến bay ";
            // 
            // txtSanBayDi
            // 
            this.txtSanBayDi.Location = new System.Drawing.Point(179, 119);
            this.txtSanBayDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanBayDi.Name = "txtSanBayDi";
            this.txtSanBayDi.Size = new System.Drawing.Size(321, 22);
            this.txtSanBayDi.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 124);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Sân bay đi";
            // 
            // txtSanBayDen
            // 
            this.txtSanBayDen.Location = new System.Drawing.Point(179, 151);
            this.txtSanBayDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanBayDen.Name = "txtSanBayDen";
            this.txtSanBayDen.Size = new System.Drawing.Size(321, 22);
            this.txtSanBayDen.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 156);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Sân bay đến";
            // 
            // lvwSanBayTrungGian
            // 
            this.lvwSanBayTrungGian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwSanBayTrungGian.Location = new System.Drawing.Point(12, 270);
            this.lvwSanBayTrungGian.Name = "lvwSanBayTrungGian";
            this.lvwSanBayTrungGian.Size = new System.Drawing.Size(508, 121);
            this.lvwSanBayTrungGian.TabIndex = 38;
            this.lvwSanBayTrungGian.UseCompatibleStateImageBehavior = false;
            this.lvwSanBayTrungGian.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sân bay trung gian";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian dừng";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ghi chú";
            this.columnHeader3.Width = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "THÊM TUYẾN BAY";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(374, 416);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(217, 416);
            this.btnTaoLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(100, 30);
            this.btnTaoLai.TabIndex = 41;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(58, 416);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // frmThemTuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 479);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwSanBayTrungGian);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtThoiGianBay);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtMaTuyenBay);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSanBayDi);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSanBayDen);
            this.Controls.Add(this.label18);
            this.Name = "frmThemTuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tuyến bay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSanBayDi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSanBayDen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView lvwSanBayTrungGian;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Button btnThem;
    }
}