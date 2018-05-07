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
    public partial class frmThemSanBay : Form
    {
        #region Properties
        DTO_SanBay dtoSanBay;
        BUS_SanBay busSanBay;
        #endregion

        #region Initializes
        public frmThemSanBay()
        {
            InitializeComponent();
            busSanBay = new BUS_SanBay();
            TuDongTaoMaSanBay();
        }
        #endregion

        #region Methods
        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            TuDongTaoMaSanBay();
            txtTenSanBay.Clear();
            txtTenThanhPho.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenSanBay.Text.Trim() != "" && txtTenThanhPho.Text.Trim() != "")
            {
                try
                {
                    dtoSanBay = new DTO_SanBay(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text);
                    if(busSanBay.Add(dtoSanBay))
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

        private void TuDongTaoMaSanBay()
        {
            DataTable dt = busSanBay.Get();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                txtMaSanBay.Text = "SB000" + count;
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
            txtMaSanBay.Text = "SB" + strSoKhong + count;
        }

        #endregion
    }
}
