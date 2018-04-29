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
            frm.SetDesktopLocation(280, 0);
            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.BackColor = Color.LightSkyBlue;
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
            frmThemTuyenBay frm = new frmThemTuyenBay();
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
            frmThemChuyenBay frm = new frmThemChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void thayDoiChuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThayDoiThongTinChuyenBay frm = new frmThayDoiThongTinChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void thayDoiKhachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThayDoiThongTinKhachHang frm = new frmThayDoiThongTinKhachHang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void xoaTuyenBayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXoaThongTinTuyenBay frm = new frmXoaThongTinTuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void xoaChuyenBayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmXoaThongTinChuyenBay frm = new frmXoaThongTinChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
        private void xoaDatVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXoaThongTinDatVe frm = new frmXoaThongTinDatVe();
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
    }

}
