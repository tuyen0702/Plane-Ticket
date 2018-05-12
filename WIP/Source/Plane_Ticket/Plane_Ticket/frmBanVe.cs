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
    public partial class frmBanVe : Form
    {
        #region Properties
        DTO_VeChuyenBay dtoVeChuyenBay;
        BUS_VeChuyenBay busVeChuyenBay;
        #endregion

        #region Initializes
        public frmBanVe()
        {
            InitializeComponent();
            busVeChuyenBay = new BUS_VeChuyenBay();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            cboMaChuyenBay.Text = "";
            txtMaTuyenBay.Clear();
            txtSanBayDi.Clear();
            txtSanBayDen.Clear();
            txtThoiGIanBay.Clear();
            txtThoiGianKhoiHanh.Clear();
            cboMaHanhKhach.Text = "";
            txtCMND.Clear();
            txtDienThoai.Clear();
            txtTenHanhKhach.Clear();
            cboHangVe.Text = "";
            txtGiaTien.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            //if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
            //{
            //    try
            //    {
            //        dtoVeChuyenBay = new DTO_VeChuyenBay(txtMaVeChuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
            //        if (busVeChuyenBay.Add(dtoVeChuyenBay))
            //            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        else
            //            MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    catch (Exception a)
            //    {
            //        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        btnTaoLai_Click(sender, e);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void KhoiTaoGiaoDien()
        {
            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = new DataTable();

            dtChuyenBay = busChuyenBay.Get();
            cboMaChuyenBay.DataSource = dtChuyenBay;
            cboMaChuyenBay.DisplayMember = "MACHUYENBAY";
            cboMaChuyenBay.ValueMember = "MACHUYENBAY";

            BUS_KhachHang busKhachHang = new BUS_KhachHang();
            DataTable dtKhachHang = new DataTable();

            dtKhachHang = busKhachHang.Get();
            cboMaHanhKhach.DataSource = dtKhachHang;
            cboMaHanhKhach.DisplayMember = "MAKHACHHANG";
            cboMaHanhKhach.ValueMember = "MAKHACHHANG";

            BUS_HangVe busHangVe = new BUS_HangVe();
            DataTable dtHangVe = new DataTable();

            dtHangVe = busHangVe.Get();
            cboHangVe.DataSource = dtHangVe;
            cboHangVe.DisplayMember = "TENHANGVE";
            cboHangVe.ValueMember = "MAHANGVE";
        }
        private void cboMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(cboMaChuyenBay.Text);

            foreach (DataRow row in dtChuyenBay.Rows)
            {
                txtMaTuyenBay.Text = row["MATUYENBAY"].ToString();
                txtSanBayDi.Text = row["MASANBAYDI"].ToString();
                txtSanBayDen.Text = row["MASANBAYDEN"].ToString();
                txtThoiGianKhoiHanh.Text = row["THOIGIANKHOIHANH"].ToString();
                txtThoiGIanBay.Text = row["THOIGIANBAY"].ToString();
            }
        }
        private void cboMaHanhKhach_SelectedValueChanged(object sender, EventArgs e)
        {
            BUS_KhachHang busKhachHang = new BUS_KhachHang();
            DataTable dtKhachHang = busKhachHang.GetOfMaKhachHang(cboMaHanhKhach.Text);

            foreach (DataRow row in dtKhachHang.Rows)
            {
                txtTenHanhKhach.Text = row["TENKHACHHANG"].ToString();
                txtCMND.Text = row["CMND"].ToString();
                txtDienThoai.Text = row["SDT"].ToString();
            }
        }
        private void cboHangVe_SelectedValueChanged(object sender, EventArgs e)
        {
            BUS_DonGia busDonGia = new BUS_DonGia();
            DataTable dtDonGia = busDonGia.SearchOfMaTuyenBayAndMaHangVe(txtMaTuyenBay.Text, cboHangVe.SelectedValue.ToString());

            foreach (DataRow row in dtDonGia.Rows)
            {
                txtGiaTien.Text = row["DONGIA"].ToString();
            }
        }

        #endregion

        private void frmBanVe_Load(object sender, EventArgs e)
        {

        }
    }
}
