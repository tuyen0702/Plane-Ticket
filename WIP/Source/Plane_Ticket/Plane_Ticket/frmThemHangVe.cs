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
    public partial class frmThemHangVe : Form
    {
        #region Properties
        DTO_HangVe dtoHangVe;
        BUS_HangVe busHangVe;
        #endregion

        #region Initializes
        public frmThemHangVe()
        {
            InitializeComponent();
            busHangVe = new BUS_HangVe();
            TuDongTaoMaHangVe();
        }
        #endregion

        #region Methods
        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            TuDongTaoMaHangVe();
            txtTenHangVe.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenHangVe.Text.Trim() != "")
            {
                try
                {
                    dtoHangVe = new DTO_HangVe(txtMaHangVe.Text, txtTenHangVe.Text);
                    if(busHangVe.Add(dtoHangVe))
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

        private void TuDongTaoMaHangVe()
        {
            DataTable dt = busHangVe.Get();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                txtMaHangVe.Text = "HV000" + count;
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
            txtMaHangVe.Text = "HV" + strSoKhong + count;
        }
        #endregion
    }
}
