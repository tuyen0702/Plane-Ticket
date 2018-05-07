using BUS;
using DTO;
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
    public partial class frmThemMayBay : Form
    {
        #region Properties
        DTO_MayBay dtoMayBay;
        BUS_MayBay busMayBay;
        #endregion

        #region Initializes
        public frmThemMayBay()
        {
            InitializeComponent();
            busMayBay = new BUS_MayBay();         
            TuDongTaoMaMayBay();
        }
        #endregion

        #region Methods
        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            TuDongTaoMaMayBay();
            txtTenMayBay.Clear();
            txtSoLuongGhe.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenMayBay.Text.Trim() != "" && txtSoLuongGhe.Text.Trim() != "")
            {
                try
                {
                    dtoMayBay = new DTO_MayBay(txtMaMayBay.Text, txtTenMayBay.Text,Convert.ToInt32(txtSoLuongGhe.Text));
                    if(busMayBay.Add(dtoMayBay))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnTaoLai_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void TuDongTaoMaMayBay()
        {
            DataTable dt = busMayBay.Get();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                txtMaMayBay.Text = "MB000" + count;
                return;
            }
            string strSoKhong = "";
            int temp = count;
            int dem = 0;
            while (temp > 0)
            {
                temp /= 10;
                dem++;
            }
            for (int i = 0; i < 4 - dem; i++)
            {
                strSoKhong += "0";
            }
            txtMaMayBay.Text = "MB" + strSoKhong + count;
        }

        #endregion
    }
}
