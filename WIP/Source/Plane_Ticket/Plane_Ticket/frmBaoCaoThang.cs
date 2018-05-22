using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Ticket
{
    public partial class frmBaoCaoThang : Form
    {
        public frmBaoCaoThang()
        {
            InitializeComponent();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            BUS_SanBay busSanBay = new BUS_SanBay();
            DataTable dtBaoCaoThang = busSanBay.Get();
            crBaoCaoThang cr = new crBaoCaoThang();
            cr.SetDataSource(dtBaoCaoThang);
            crvBaoCaoThang.ReportSource = cr;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
