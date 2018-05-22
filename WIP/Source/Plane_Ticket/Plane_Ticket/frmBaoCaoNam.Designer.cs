namespace Plane_Ticket
{
    partial class frmBaoCaoNam
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
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.crvBaoCaoNam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label17 = new System.Windows.Forms.Label();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(517, 67);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(91, 24);
            this.cboNam.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 58);
            this.panel1.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "BÁO CÁO NĂM";
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
            // 
            // crvBaoCaoNam
            // 
            this.crvBaoCaoNam.ActiveViewIndex = -1;
            this.crvBaoCaoNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCaoNam.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCaoNam.Location = new System.Drawing.Point(12, 99);
            this.crvBaoCaoNam.Name = "crvBaoCaoNam";
            this.crvBaoCaoNam.Size = new System.Drawing.Size(1240, 568);
            this.crvBaoCaoNam.TabIndex = 125;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(473, 74);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 124;
            this.label17.Text = "Năm";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Location = new System.Drawing.Point(615, 65);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(105, 28);
            this.btnXemBaoCao.TabIndex = 123;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // frmBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 678);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crvBaoCaoNam);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnXemBaoCao);
            this.Name = "frmBaoCaoNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo năm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoNam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}