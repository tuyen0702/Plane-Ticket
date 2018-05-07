using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_VeChuyenBay
    {
        private string maVe;
        private string maChuyenBay;
        private string maHangVe;
        private int giaTien;
        private string tinhTrang;
        private DateTime ngayHuy;
        public DTO_VeChuyenBay()
        {
        }

        public DTO_VeChuyenBay(string maVe, string maChuyenBay, string maHangVe, int giaTien, string tinhTrang, DateTime ngayHuy)
        {
            this.MaVe = maVe;
            this.MaChuyenBay = maChuyenBay;
            this.MaHangVe = maHangVe;
            this.GiaTien = giaTien;
            this.TinhTrang = tinhTrang;
            this.NgayHuy = ngayHuy;
        }

        public string MaVe { get => maVe; set => maVe = value; }
        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public DateTime NgayHuy { get => ngayHuy; set => ngayHuy = value; }
        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
    }
}
