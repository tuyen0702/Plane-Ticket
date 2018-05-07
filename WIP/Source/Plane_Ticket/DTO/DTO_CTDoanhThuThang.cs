using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTDoanhThuThang
    {
        private string maDoanhThuThang;
        private string maChuyenBay;
        private int soVeBanDuoc;
        private long doanhThu;

        public DTO_CTDoanhThuThang()
        {
        }
        public DTO_CTDoanhThuThang( string maDoanhThuThang, string maChuyenBay, int soVeBanDuoc, long doanhThu)
        {
            this.MaDoanhThuThang = maDoanhThuThang;
            this.MaChuyenBay = maChuyenBay;
            this.SoVeBanDuoc = soVeBanDuoc;
            this.DoanhThu = doanhThu;
        }

        public string MaDoanhThuThang { get => maDoanhThuThang; set => maDoanhThuThang = value; }
        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public int SoVeBanDuoc { get => soVeBanDuoc; set => soVeBanDuoc = value; }
        public long DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}
