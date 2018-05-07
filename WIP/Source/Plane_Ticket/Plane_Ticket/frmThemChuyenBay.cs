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
    public partial class frmThemChuyenBay : Form
    {
        #region Properties
        DTO_ChuyenBay dtoChuyenBay;
        BUS_ChuyenBay busChuyenBay;
        DTO_TinhTrangVe dtoTinhTrangVe;
        BUS_TinhTrangVe busTinhTrangVe;
        #endregion

        #region Initializes
        public frmThemChuyenBay()
        {
            InitializeComponent();
            busChuyenBay = new BUS_ChuyenBay();
            busTinhTrangVe = new BUS_TinhTrangVe();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods
        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            TuDongTaoMaChuyenBay();
            cboMaTuyenBay.Text = "";
            cboMaMayBay.Text = "";
            txtThoiGianKH.Text = "";
            txtThoiGianBay.Text = "";
            txtTongSoGhe.Clear();
            cboMaHangVe.Enabled = false;
            txtTongSoGhe.Enabled = false;
            btnThemTTGheCuaChuyenBay.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cboMaTuyenBay.Text.Trim() != "" && cboMaMayBay.Text.Trim() != "" && txtThoiGianKH.Text.Trim()!="" && txtThoiGianBay.Text.Trim()!="")
            {
                try
                {
                    dtoChuyenBay = new DTO_ChuyenBay(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, Convert.ToDateTime(txtThoiGianKH.Text),Convert.ToDateTime(txtThoiGianBay.Text));
                    busChuyenBay.Add(dtoChuyenBay);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThemTTGheCuaChuyenBay.Enabled = true;
                    cboMaHangVe.Enabled = true;
                    txtTongSoGhe.Enabled = true;
                }

                catch (Exception a)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TuDongTaoMaChuyenBay()
        {
            DataTable dt = busChuyenBay.Get();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                txtMaChuyenBay.Text = "CB000" + count;
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
            txtMaChuyenBay.Text = "CB" + strSoKhong + count;
        }
        
        private void KhoiTaoGiaoDien()
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            BUS_MayBay busMayBay = new BUS_MayBay();
            BUS_HangVe busHangVe = new BUS_HangVe();

            DataTable dtTuyenBay = new DataTable();
            DataTable dtMayBay = new DataTable();
            DataTable dtHangVe = new DataTable();

            dtTuyenBay = busTuyenBay.Get();
            dtMayBay = busMayBay.Get();
            dtHangVe = busHangVe.Get();

            cboMaTuyenBay.DataSource = dtTuyenBay;
            cboMaTuyenBay.DisplayMember = "MATUYENBAY";
            cboMaTuyenBay.ValueMember = "MATUYENBAY";

            cboMaMayBay.DataSource = dtMayBay;
            cboMaMayBay.DisplayMember = "MAMAYBAY";
            cboMaMayBay.ValueMember = "MAMAYBAY";

            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "TENHANGVE";
            cboMaHangVe.ValueMember = "MAHANGVE";

            TuDongTaoMaChuyenBay();
            btnThemTTGheCuaChuyenBay.Enabled = false;
            cboMaHangVe.Enabled = false;
            txtTongSoGhe.Enabled = false;
        }

        private void btnThemTTGheCuaChuyenBay_Click(object sender, EventArgs e)
        {
            if (cboMaHangVe.Text.Trim() != "" && txtTongSoGhe.Text.Trim() != "")
            {
                try
                {
                    dtoTinhTrangVe= new DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(),Convert.ToInt32(txtTongSoGhe.Text),Convert.ToInt32(txtTongSoGhe.Text));
                    if(busTinhTrangVe.Add(dtoTinhTrangVe))
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
                    txtTongSoGhe.Clear();
                    TaoBangThongTinGheCuaChuyenBay();
                    cboMaHangVe.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TaoBangThongTinGheCuaChuyenBay()
        {
            lvwThongTinGheCuaChuyenBay.Items.Clear();
            DataTable dtTinhTrangVe = new DataTable();
            dtTinhTrangVe = busTinhTrangVe.GetOfMaChuyenBay(txtMaChuyenBay.Text);
            int i = 0;
            foreach(DataRow row in dtTinhTrangVe.Rows)
            {
                lvwThongTinGheCuaChuyenBay.Items.Add(row["MAHANGVE"].ToString());
                lvwThongTinGheCuaChuyenBay.Items[i].SubItems.Add(row["TENHANGVE"].ToString());
                lvwThongTinGheCuaChuyenBay.Items[i].SubItems.Add(row["TONGSOGHE"].ToString());
                lvwThongTinGheCuaChuyenBay.Items[i].SubItems.Add(row["SOGHETRONG"].ToString());
                i++;
            }
        }
        #endregion
    }
}
