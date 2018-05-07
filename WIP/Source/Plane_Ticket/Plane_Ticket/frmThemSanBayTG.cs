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
    public partial class frmThemSanBayTG : Form
    {
        #region Properties
        DTO_CTChuyenBay dtoCTChuyenBay;
        BUS_CTChuyenBay busCTChuyenBay;
        #endregion

        #region Initializes
        public frmThemSanBayTG()
        {
            InitializeComponent();
            busCTChuyenBay = new BUS_CTChuyenBay();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThoiGianNghi.Text.Trim() != "" && cboTenSanBay.Text.Trim() != "" && txtGhiChu.Text.Trim() != "")
            {
                try
                {
                    dtoCTChuyenBay = new DTO_CTChuyenBay(cboMaChuyenBay.Text,cboTenSanBay.SelectedValue.ToString(),Convert.ToDateTime(txtThoiGianNghi.Text), txtGhiChu.Text);
                    if(busCTChuyenBay.Add(dtoCTChuyenBay))
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

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            cboTenSanBay.Text = "";
            txtThoiGianNghi.Clear();
            txtGhiChu.Clear();
            TaoBangSanBayTG();
            lvwSanBayTrungGian.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void KhoiTaoGiaoDien()
        {
            BUS_SanBay busSanBay = new BUS_SanBay();
            DataTable dtSanBay = new DataTable();

            dtSanBay = busSanBay.Get();
            cboTenSanBay.DataSource = dtSanBay;
            cboTenSanBay.DisplayMember = "TENSANBAY";
            cboTenSanBay.ValueMember = "MASANBAY";

            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = new DataTable();

            dtChuyenBay = busChuyenBay.Get();
            cboMaChuyenBay.DataSource = dtChuyenBay;
            cboMaChuyenBay.DisplayMember = "MACHUYENBAY";
            cboMaChuyenBay.ValueMember = "MACHUYENBAY";
        }
        private void TaoBangSanBayTG()
        {
            lvwSanBayTrungGian.Items.Clear();
            DataTable dtCTChuyenBay = new DataTable();
            dtCTChuyenBay = busCTChuyenBay.TimSanBayTGCuaChuyenBay(cboMaChuyenBay.Text);
            int i = 0;
            foreach (DataRow row in dtCTChuyenBay.Rows)
            {
                lvwSanBayTrungGian.Items.Add(row["MASANBAYTG"].ToString());
                lvwSanBayTrungGian.Items[i].SubItems.Add(row["THOIGIANDUNG"].ToString());
                lvwSanBayTrungGian.Items[i].SubItems.Add(row["GHICHU"].ToString());
                i++;
            }
        }

        private void cboMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            TaoBangSanBayTG();
        }

        #endregion
    }
}
