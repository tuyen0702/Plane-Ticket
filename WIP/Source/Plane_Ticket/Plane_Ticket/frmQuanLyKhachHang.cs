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
    public partial class frmQuanLyKhachHang : Form
    {
        #region Properties
        DTO_KhachHang dtoKhachHang;
        BUS_KhachHang busKhachHang;
        #endregion

        #region Initializes
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            busKhachHang = new BUS_KhachHang();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            TuDongTaoMaKhachHang();
            txtTenKhachHang.Clear();
            txtCMND.Clear();
            txtSDT.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenKhachHang.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtSDT.Text.Trim()!="")
            {
                try
                {
                    dtoKhachHang = new DTO_KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text);
                    if (busKhachHang.Add(dtoKhachHang))
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
        private void TuDongTaoMaKhachHang()
        {
            DataTable dt = busKhachHang.Get();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                txtMaKhachHang.Text = "KH000" + count;
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
            txtMaKhachHang.Text = "KH" + strSoKhong + count;
        }
        private void KhoiTaoGiaoDien()
        {
            TuDongTaoMaKhachHang();
        }

        #endregion
    }
}
