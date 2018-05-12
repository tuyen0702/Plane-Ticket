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
    public partial class frmQuanLyChuyenBay : Form
    {
        #region Properties
        DTO_ChuyenBay dtoChuyenBay;
        BUS_ChuyenBay busChuyenBay;
        DTO_TinhTrangVe dtoTinhTrangVe;
        BUS_TinhTrangVe busTinhTrangVe;
        DTO_CTChuyenBay dtoCTChuyenBay;
        BUS_CTChuyenBay busCTChuyenBay;

        #endregion

        #region Initializes
        public frmQuanLyChuyenBay()
        {
            InitializeComponent();
            busChuyenBay = new BUS_ChuyenBay();
            busTinhTrangVe = new BUS_TinhTrangVe();
            busCTChuyenBay = new BUS_CTChuyenBay();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods
        private void KhoiTaoGiaoDien()
        {
            KhoiTaoGiaoDienChuyenBay();
            KhoiTaoGiaoDienHangVe();
            KhoiTaoGiaoDienSBTG();
        }

        #region ChuyenBay
        private void TaoLaiChuyenBay()
        {
            TaoBangDSChuyenBay();
            txtMaChuyenBay.Clear();
            cboMaTuyenBay.Text = "";
            cboSanBayDi.Text = "";
            cboSanBayDen.Text = "";
            cboMaMayBay.Text = "";
            txtThoiGianKH.Clear();
            txtThoiGianBay.Clear();
            gbxThemHangVeChoChuyenBay.Enabled = false;
            gbxThemSanBayTGChoChuyenBay.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cboMaTuyenBay.Text.Trim() != "" && cboMaMayBay.Text.Trim() != "" && txtThoiGianKH.Text.Trim()!="" && txtThoiGianBay.Text.Trim()!="")
            {
                try
                {
                    dtoChuyenBay = new DTO_ChuyenBay(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, Convert.ToDateTime(txtThoiGianKH.Text),Convert.ToDateTime(txtThoiGianBay.Text));
                    if(busChuyenBay.Add(dtoChuyenBay))
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
                    TaoLaiChuyenBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Text.Trim() != "")
            {
                if (cboMaTuyenBay.Text.Trim() != "" && cboMaMayBay.Text.Trim() != "" && txtThoiGianKH.Text.Trim() != "" && txtThoiGianBay.Text.Trim() != "")
                {
                    try
                    {
                        dtoChuyenBay = new DTO_ChuyenBay(txtMaChuyenBay.Text, cboMaTuyenBay.Text, cboMaMayBay.Text, Convert.ToDateTime(txtThoiGianKH.Text), Convert.ToDateTime(txtThoiGianBay.Text));
                        if (busChuyenBay.Update(dtoChuyenBay))
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        TaoLaiChuyenBay();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Text.Trim() != "")
            {
                try
                {
                    if (busChuyenBay.Delete(txtMaChuyenBay.Text))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception a)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLaiChuyenBay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvChuyenBay.DataSource = busChuyenBay.SearchOfMaChuyenBay(txtTimKiem.Text);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void TaoBangDSChuyenBay()
        {
            DataTable dtChuyenBay = busChuyenBay.GetToDisplay();
            dtgvChuyenBay.DataSource = dtChuyenBay;
            dtgvChuyenBay.Sort(dtgvChuyenBay.Columns[0], ListSortDirection.Descending);
            dtgvChuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void KhoiTaoGiaoDienChuyenBay()
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            BUS_MayBay busMayBay = new BUS_MayBay();
            BUS_HangVe busHangVe = new BUS_HangVe();
            BUS_SanBay busSanBay = new BUS_SanBay();

            DataTable dtTuyenBay = new DataTable();
            DataTable dtMayBay = new DataTable();
            DataTable dtHangVe = new DataTable();
            DataTable dtSanBay = new DataTable();

            dtTuyenBay = busTuyenBay.Get();
            dtMayBay = busMayBay.Get();
            dtHangVe = busHangVe.Get();
            dtSanBay = busSanBay.Get();

            cboMaTuyenBay.DataSource = dtTuyenBay;
            cboMaTuyenBay.DisplayMember = "MATUYENBAY";
            cboMaTuyenBay.ValueMember = "MATUYENBAY";

            cboMaMayBay.DataSource = dtMayBay;
            cboMaMayBay.DisplayMember = "MAMAYBAY";
            cboMaMayBay.ValueMember = "MAMAYBAY";

            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "TENHANGVE";
            cboMaHangVe.ValueMember = "MAHANGVE";

            BUS_SanBay busSanBayDi = new BUS_SanBay();
            DataTable dtSanBayDi = new DataTable();
            dtSanBayDi = busSanBayDi.Get();
            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "TENSANBAY";
            cboSanBayDi.ValueMember = "MASANBAY";

            
            DataTable dtSanBayDen = new DataTable();
            dtSanBayDen = busSanBayDi.Get();
            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "TENSANBAY";
            cboSanBayDen.ValueMember = "MASANBAY";

            gbxThemHangVeChoChuyenBay.Enabled = false;
            gbxThemSanBayTGChoChuyenBay.Enabled = false;

            AcceptButton = btnThem;
            CancelButton = btnThoat;

            TaoBangDSChuyenBay();
        }
        private void cboMaTuyenBay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            DataTable dtTuyenBay = busTuyenBay.GetOfMaTuyenBay(cboMaTuyenBay.Text);
            if (dtTuyenBay.Rows.Count == 0)
                return;
            DataRow row = dtTuyenBay.Rows[0];
            cboSanBayDi.Text = row["TENSANBAYDI"].ToString();
            cboSanBayDi.SelectedValue = row["MASANBAYDI"].ToString();
            cboSanBayDen.Text = row["TENSANBAYDEN"].ToString();
            cboSanBayDen.SelectedValue = row["MASANBAYDEN"].ToString();
        }
        private void cboSanBayDi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            DataTable dtTuyenBay = busTuyenBay.GetOfMaSanBay(cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
            if (dtTuyenBay.Rows.Count == 0)
            {
                cboMaTuyenBay.Text = "";
            }
            else
            {
                DataRow row = dtTuyenBay.Rows[0];
                cboMaTuyenBay.Text = row["MATUYENBAY"].ToString();
            }
        }
        private void dtgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvChuyenBay.Rows[e.RowIndex];
            txtMaChuyenBay.Text = row.Cells[0].Value.ToString();
            cboMaTuyenBay.SelectedValue = row.Cells[1].Value.ToString();
            cboMaMayBay.SelectedValue= row.Cells[2].Value.ToString();
            txtThoiGianKH.Text= row.Cells[3].Value.ToString();
            txtThoiGianBay.Text = row.Cells[3].Value.ToString();
            cboMaTuyenBay_SelectionChangeCommitted(sender, e);

            gbxThemHangVeChoChuyenBay.Enabled = true;
            gbxThemSanBayTGChoChuyenBay.Enabled = true;

            TaoBangDSHangVeCuaChuyenBay();
            TaoBangDSSanBayTG();

        }
        #endregion

        #region HangVe
        bool flagHangVeCellClick = false;
        private void TaoLaiHangVe()
        {
            TaoBangDSHangVeCuaChuyenBay();
            txtTongSoGhe.Text = "";
            flagHangVeCellClick = false;
        }
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            if (cboMaHangVe.Text!="" && txtTongSoGhe.Text!="")
            {
                try
                {
                    dtoTinhTrangVe = new DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtTongSoGhe.Text), Convert.ToInt32(txtTongSoGhe.Text));
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
                    TaoLaiHangVe();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            if (flagHangVeCellClick)
            {
                if (cboMaHangVe.Text != "" && txtTongSoGhe.Text != "")
                {
                    try
                    {
                        DTO_TinhTrangVe dtoTinhTrangVe = new DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtTongSoGhe.Text), Convert.ToInt32(txtTongSoGhe.Text));
                        if (busTinhTrangVe.Update(dtoTinhTrangVe))
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        TaoLaiHangVe();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            if (flagHangVeCellClick)
            {
                try
                {
                    DTO_TinhTrangVe dtoTinhTrangVe = new DTO_TinhTrangVe(txtMaChuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtTongSoGhe.Text), Convert.ToInt32(txtTongSoGhe.Text));
                    if (busTinhTrangVe.Delete(dtoTinhTrangVe))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception a)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLaiHangVe();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void KhoiTaoGiaoDienHangVe()
        {
            BUS_HangVe busHangVe = new BUS_HangVe();
            DataTable dtHangVe = busHangVe.Get();
            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "TENHANGVE";
            cboMaHangVe.ValueMember = "MAHANGVE";

        }
        private void TaoBangDSHangVeCuaChuyenBay()
        {
            BUS_TinhTrangVe busTinhTrangVe = new BUS_TinhTrangVe();
            DataTable dtTinhTrangVe = busTinhTrangVe.GetForDisplayOfMaChuyenBay(txtMaChuyenBay.Text);
            dtgvHangVe.DataSource = dtTinhTrangVe;
            dtgvHangVe.Sort(dtgvHangVe.Columns[0], ListSortDirection.Descending);
            dtgvHangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvHangVe.Rows[e.RowIndex];
            cboMaHangVe.Text = row.Cells[0].Value.ToString();
            txtTongSoGhe.Text = row.Cells[1].Value.ToString();

            flagHangVeCellClick = true;
        }
        #endregion

        #region SanBayTG
        bool flagSBTGCellClick = false;
        private void TaoLaiSBTG()
        {
            TaoBangDSSanBayTG();
            txtThoiGianNghi.Clear();
            txtGhiChu.Clear();
            flagSBTGCellClick = false;
        }
        private void btnThemSBTG_Click(object sender, EventArgs e)
        {
            if (cboTenSanBayTG.Text!="" && txtThoiGianNghi.Text!="" && txtGhiChu.Text!="")
            {
                try
                {
                    dtoCTChuyenBay = new DTO_CTChuyenBay(txtMaChuyenBay.Text,cboTenSanBayTG.SelectedValue.ToString(),Convert.ToDateTime(txtThoiGianNghi.Text),txtGhiChu.Text);
                    if (busCTChuyenBay.Add(dtoCTChuyenBay))
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
                    TaoLaiSBTG();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSuaSBTG_Click(object sender, EventArgs e)
        {
            if (flagSBTGCellClick)
            {
                if (cboTenSanBayTG.Text != "" && txtThoiGianNghi.Text != "" && txtGhiChu.Text != "")
                {
                    try
                    {
                        dtoCTChuyenBay = new DTO_CTChuyenBay(txtMaChuyenBay.Text, cboTenSanBayTG.SelectedValue.ToString(), Convert.ToDateTime(txtThoiGianNghi.Text), txtGhiChu.Text);
                        if (busCTChuyenBay.Update(dtoCTChuyenBay))
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        TaoLaiSBTG();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXoaSBTG_Click(object sender, EventArgs e)
        {
            if (flagSBTGCellClick)
            {
                try
                {
                    dtoCTChuyenBay = new DTO_CTChuyenBay(txtMaChuyenBay.Text, cboTenSanBayTG.SelectedValue.ToString(), Convert.ToDateTime(txtThoiGianNghi.Text), txtGhiChu.Text);
                    if (busCTChuyenBay.Delete(dtoCTChuyenBay))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception a)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLaiSBTG();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void KhoiTaoGiaoDienSBTG()
        {
            BUS_SanBay busSanBay = new BUS_SanBay();
            DataTable dtSanBay = busSanBay.Get();
            cboTenSanBayTG.DataSource = dtSanBay;
            cboTenSanBayTG.DisplayMember = "TENSANBAY";
            cboTenSanBayTG.ValueMember = "MASANBAY";


        }
        private void TaoBangDSSanBayTG()
        {
            BUS_CTChuyenBay busCTChuyenBay = new BUS_CTChuyenBay();
            DataTable dtCTChuyenBay = busCTChuyenBay.GetForDisplayOfMaChuyenBay(txtMaChuyenBay.Text);
            dtgvSanBayTG.DataSource = dtCTChuyenBay;
            dtgvSanBayTG.Sort(dtgvSanBayTG.Columns[0], ListSortDirection.Descending);
            dtgvSanBayTG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanBayTG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvSanBayTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvSanBayTG.Rows[e.RowIndex];
            cboTenSanBayTG.Text = row.Cells[0].Value.ToString();
            txtThoiGianNghi.Text = row.Cells[1].Value.ToString();
            txtGhiChu.Text = row.Cells[2].Value.ToString();

            flagSBTGCellClick = true;
        }

        #endregion
        #endregion

        
    }
}
