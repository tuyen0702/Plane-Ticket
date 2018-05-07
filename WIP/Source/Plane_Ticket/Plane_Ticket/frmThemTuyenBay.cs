using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Plane_Ticket
{
    public partial class frmThemTuyenBay : Form
    {
        #region Properties
        DTO_TuyenBay dtoTuyenBay;
        BUS_TuyenBay busTuyenBay;
        #endregion

        #region Initializes
        public frmThemTuyenBay()
        {
            InitializeComponent();
            busTuyenBay = new BUS_TuyenBay();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            TuDongTaoMaTuyenBay();
            cboSanBayDen.Text = "";
            cboSanBayDi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if(cboSanBayDen.Text.Trim()!="" && cboSanBayDi.Text.Trim()!="")
            {
                try
                {
                    dtoTuyenBay = new DTO_TuyenBay(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
                    if(busTuyenBay.Add(dtoTuyenBay))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception a)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        private void TuDongTaoMaTuyenBay()
        {
            DataTable dt = busTuyenBay.Get();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                txtMaTuyenBay.Text = "TB000" + count;
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
            txtMaTuyenBay.Text = "TB" + strSoKhong + count;
        }
        private void KhoiTaoGiaoDien()
        {
            BUS_SanBay busSanBay = new BUS_SanBay();
            DataTable dtSanBayDen = new DataTable();
            DataTable dtSanBayDi = new DataTable();

            dtSanBayDen = busSanBay.Get();
            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "TENSANBAY";
            cboSanBayDen.ValueMember = "MASANBAY";

            dtSanBayDi = busSanBay.Get();
            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "TENSANBAY";
            cboSanBayDi.ValueMember = "MASANBAY";
            TuDongTaoMaTuyenBay();
        }

        #endregion
    }
}
