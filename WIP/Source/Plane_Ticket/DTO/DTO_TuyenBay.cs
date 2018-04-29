using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TuyenBay
    {
        private string maTuyenBay;
        private string maSanBayDi;
        private string maSanBayDen;
        private string maSanBayTG;
        private DateTime thoiGianNghi;
        private DateTime thoiGianBay;
        public DTO_TuyenBay()
        {
        }
        public DTO_TuyenBay(string maTuyenBay, string maSanBayDi, string maSanBayDen, string maSanBayTG, DateTime thoiGianNghi, DateTime thoiGianBay)
        {
            this.maTuyenBay = maTuyenBay;
            this.maSanBayDi = maSanBayDi;
            this.maSanBayDen = maSanBayDen;
            this.MaSanBayTG = maSanBayTG;
            this.ThoiGianNghi = thoiGianNghi;
            this.thoiGianBay = thoiGianBay;
        }

        public string MaTuyenBay { get => maTuyenBay; set => maTuyenBay = value; }
        public string MaSanBayDi { get => maSanBayDi; set => maSanBayDi = value; }
        public string MaSanBayDen { get => maSanBayDen; set => maSanBayDen = value; }
        public DateTime ThoiGianBay { get => thoiGianBay; set => thoiGianBay = value; }
        public DateTime ThoiGianNghi { get => thoiGianNghi; set => thoiGianNghi = value; }
        public string MaSanBayTG { get => maSanBayTG; set => maSanBayTG = value; }
    }
}
