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
        BUS_ChuyenBay busChuyenBay=new BUS_ChuyenBay();
        public frmThemChuyenBay()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            
            cboMaTuyenBay.Text = "";
            cboMaMayBay.Text = "";
            txtThoiGianKhoiHanh.Clear();
            txtThoiGianKetThuc.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaTuyenBay.Text != "" && cboMaMayBay.Text != "" && txtThoiGianKhoiHanh.Text != "" && txtThoiGianKetThuc.Text != "")
            {
                
                DateTime ThoiGianKhoiHanh = Convert.ToDateTime(txtThoiGianKhoiHanh.Text);
               
                DateTime ThoiGianKetThuc = Convert.ToDateTime(txtThoiGianKetThuc.Text);
        
                DTO_ChuyenBay dto = new DTO_ChuyenBay(cboMaTuyenBay.Text, cboMaMayBay.Text, ThoiGianKhoiHanh, ThoiGianKetThuc);
                if(busChuyenBay.Add(dto))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
