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
    public partial class frmQuanLySanBay : Form
    {
        #region Properties
        DTO_SanBay dtoSanBay;
        BUS_SanBay busSanBay;
        #endregion

        #region Initializes
        public frmQuanLySanBay()
        {
            InitializeComponent();
            busSanBay = new BUS_SanBay();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods
        private void TaoLai()
        {
            TaoBangDSSanBay();
            txtMaSanBay.Clear();
            txtTenSanBay.Clear();
            txtTenThanhPho.Clear();
            txtTenSanBay.Focus();
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
                    TaoLai();
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Trim() != "")
            {
                if (txtTenSanBay.Text.Trim() != "" && txtTenThanhPho.Text.Trim() != "")
                {
                    try
                    {
                        dtoSanBay = new DTO_SanBay(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text);
                        if (busSanBay.Update(dtoSanBay))
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
                        TaoLai();
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
            if (txtMaSanBay.Text.Trim() != "")
            {
                try
                {
                    string maSanBay = txtMaSanBay.Text;
                    if (busSanBay.Delete(maSanBay))
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
                    TaoLai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TaoBangDSSanBay()
        {
            DataTable dtSanBay = busSanBay.GetForDisplay();
            dtgvSanBay.DataSource = dtSanBay;
            dtgvSanBay.Sort(dtgvSanBay.Columns[0], ListSortDirection.Descending);
            dtgvSanBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvSanBay.Rows[e.RowIndex];
            txtMaSanBay.Text = row.Cells[0].Value.ToString();
            txtTenSanBay.Text = row.Cells[1].Value.ToString();
            txtTenThanhPho.Text = row.Cells[2].Value.ToString();
        }
        private void KhoiTaoGiaoDien()
        {
            TaoBangDSSanBay();

            txtTenSanBay.Focus();

            txtMaSanBay.TabStop = false;

            gbxTTSanBay.TabIndex = 0;
            gbxThaoTac.TabIndex = 1;
            gbxDSSanBay.TabIndex = 2;

            txtTenSanBay.TabIndex = 0;
            txtTenThanhPho.TabIndex = 1;
            btnThem.TabIndex = 3;
            btnSua.TabIndex = 4;
            btnXoa.TabIndex = 5;
            txtTimKiem.TabIndex = 6;
            btnTimKiem.TabIndex = 7;
            dtgvSanBay.TabIndex = 8;
            btnThoat.TabIndex = 9;

            AcceptButton = btnThem;
            CancelButton = btnThoat;
        }
        private void frmQuanLySanBay_Shown(object sender, EventArgs e)
        {
            txtTenSanBay.Focus();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvSanBay.DataSource = busSanBay.SearchOfMaSanBay(txtTimKiem.Text);
        }
        #endregion


    }
}
