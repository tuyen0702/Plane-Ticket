using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Plane_Ticket
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmDangNhap frm = new frmDangNhap();
            CreateTabPage(frm);
        }

        private bool CheckExistForm(Form frm)
        {
            foreach(TabPage t in tabCtrlMain.TabPages)
            {
                if (frm.Text == t.Text) 
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private void ActiveChildForm(Form frm)
        {
            foreach (TabPage t in tabCtrlMain.TabPages)
            {
                if (frm.Text == t.Text)
                {
                    tabCtrlMain.SelectedTab = t;
                    break;
                }
            }
        }

        private TabPage CreateTabPage(Form frm)
        {
            TabPage tabPage = new TabPage { Text = frm.Text };
            tabPage.BorderStyle = BorderStyle.None;
            tabPage.BackgroundImage = Properties.Resources.background;
            tabPage.BackgroundImageLayout = ImageLayout.Stretch;
            tabCtrlMain.TabPages.Add(tabPage);
            tabCtrlMain.SelectedTab = tabPage;
            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.BackColor = Color.White;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            return tabPage;
        }
        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }  
        }
        private void banVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanVe frm = new frmBanVe();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themTuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTuyenBay frm = new frmQuanLyTuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themChuyenBayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyChuyenBay frm = new frmQuanLyChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void traCuuChuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuChuyenBay frm = new frmTraCuuChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void traCuuKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuuKhachHang frm = new frmTraCuuKhachHang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void baoCaoThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThang frm = new frmBaoCaoThang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void baoCaoNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoNam frm = new frmBaoCaoNam();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themSanBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySanBay frm = new frmQuanLySanBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themMayBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMayBay frm = new frmQuanLyMayBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themHangVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHangVe frm = new frmQuanLyHangVe();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void themDonGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDonGia frm = new frmQuanLyDonGia();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
