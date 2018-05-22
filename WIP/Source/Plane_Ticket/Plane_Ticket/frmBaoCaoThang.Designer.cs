namespace Plane_Ticket
{
    partial class frmBaoCaoThang
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
            this.label17 = new System.Windows.Forms.Label();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.crvBaoCaoThang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(461, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Tháng";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Location = new System.Drawing.Point(615, 64);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(105, 28);
            this.btnXemBaoCao.TabIndex = 9;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // crvBaoCaoThang
            // 
            this.crvBaoCaoThang.ActiveViewIndex = -1;
            this.crvBaoCaoThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCaoThang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCaoThang.Location = new System.Drawing.Point(12, 98);
            this.crvBaoCaoThang.Name = "crvBaoCaoThang";
            this.crvBaoCaoThang.Size = new System.Drawing.Size(1240, 568);
            this.crvBaoCaoThang.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 58);
            this.panel1.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "BÁO CÁO THÁNG";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1206, 4);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 50);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(517, 66);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(91, 24);
            this.cboThang.TabIndex = 122;
            // 
            // frmBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 678);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crvBaoCaoThang);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnXemBaoCao);
            this.Name = "frmBaoCaoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tháng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnXemBaoCao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoThang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboThang;
    }
}