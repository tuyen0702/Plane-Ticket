using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenBay
    {
        private string maChuyenBay;
        private string maTuyenBay;
        private string maMayBay;
        private DateTime thoiGianKhoiHanh;
        private DateTime thoiGianKetThuc;
        public DTO_ChuyenBay()
        {
        }
        public DTO_ChuyenBay(string maTuyenBay, string maMayBay, DateTime thoiGianKhoiHanh, DateTime thoiGianKetThuc)
        {
            
            this.maTuyenBay = maTuyenBay;
            this.maMayBay = maMayBay;
            this.thoiGianKhoiHanh = thoiGianKhoiHanh;
            this.thoiGianKetThuc = thoiGianKetThuc;
        }

       
        public string MaTuyenBay { get => maTuyenBay; set => maTuyenBay = value; }
        public string MaMayBay { get => maMayBay; set => maMayBay = value; }
        public DateTime ThoiGianKhoiHanh { get => thoiGianKhoiHanh; set => thoiGianKhoiHanh = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
    }
}
