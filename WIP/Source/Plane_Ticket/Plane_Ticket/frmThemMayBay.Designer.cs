namespace Plane_Ticket
{
    partial class frmThemMayBay
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
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMayBay = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTenMayBay = new System.Windows.Forms.TextBox();
            this.txtSoLuongGhe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(372, 209);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(215, 209);
            this.btnTaoLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(100, 30);
            this.btnTaoLai.TabIndex = 50;
            this.btnTaoLai.Text = "Tạo lại";
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(56, 209);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "THÊM MÁY BAY";
            // 
            // txtMaMayBay
            // 
            this.txtMaMayBay.Location = new System.Drawing.Point(175, 90);
            this.txtMaMayBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMayBay.Name = "txtMaMayBay";
            this.txtMaMayBay.ReadOnly = true;
            this.txtMaMayBay.Size = new System.Drawing.Size(321, 22);
            this.txtMaMayBay.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 95);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 17);
            this.label20.TabIndex = 45;
            this.label20.Text = "Mã máy bay ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 127);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 17);
            this.label19.TabIndex = 46;
            this.label19.Text = "Tên máy bay";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 159);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 17);
            this.label18.TabIndex = 44;
            this.label18.Text = "Số lượng ghế";
            // 
            // txtTenMayBay
            // 
            this.txtTenMayBay.Location = new System.Drawing.Point(175, 120);
            this.txtTenMayBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMayBay.Name = "txtTenMayBay";
            this.txtTenMayBay.Size = new System.Drawing.Size(321, 22);
            this.txtTenMayBay.TabIndex = 47;
            // 
            // txtSoLuongGhe
            // 
            this.txtSoLuongGhe.Location = new System.Drawing.Point(175, 154);
            this.txtSoLuongGhe.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongGhe.Name = "txtSoLuongGhe";
            this.txtSoLuongGhe.Size = new System.Drawing.Size(321, 22);
            this.txtSoLuongGhe.TabIndex = 47;
            // 
            // frmThemMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 251);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuongGhe);
            this.Controls.Add(this.txtTenMayBay);
            this.Controls.Add(this.txtMaMayBay);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Name = "frmThemMayBay";
            this.Text = "Thêm máy bay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMayBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTenMayBay;
        private System.Windows.Forms.TextBox txtSoLuongGhe;
    }
}