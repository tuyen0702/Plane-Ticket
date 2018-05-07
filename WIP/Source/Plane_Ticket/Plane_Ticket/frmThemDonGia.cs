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
    public partial class frmThemDonGia : Form
    {
        #region Properties
        DTO_DonGia dtoDonGia;
        BUS_DonGia busDonGia;
        #endregion

        #region Initializes
        public frmThemDonGia()
        {
            InitializeComponent();
            busDonGia = new BUS_DonGia();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            cboMaTuyenBay.Text = "";
            cboMaHangVe.Text = "";
            txtDonGia.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cboMaTuyenBay.Text.Trim() != "" && cboMaHangVe.Text.Trim() != "" && txtDonGia.Text!="")
            {
                try
                {
                    dtoDonGia = new DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                    if (busDonGia.Add(dtoDonGia))
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
        private void KhoiTaoGiaoDien()
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            DataTable dtTuyenBay = new DataTable();
            dtTuyenBay = busTuyenBay.Get();
            cboMaTuyenBay.DataSource = dtTuyenBay;
            cboMaTuyenBay.DisplayMember = "MATUYENBAY";
            cboMaTuyenBay.ValueMember = "MATUYENBAY";

            BUS_HangVe busHangVe = new BUS_HangVe();
            DataTable dtHangVe = new DataTable();
            dtHangVe = busHangVe.Get();
            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "MAHANGVE";
            cboMaHangVe.ValueMember = "MAHANGVE";
        }

        #endregion
    }
}
