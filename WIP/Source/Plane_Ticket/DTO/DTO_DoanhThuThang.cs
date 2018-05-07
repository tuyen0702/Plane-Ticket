using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoanhThuThang
    {
        private string maDoanhThuThang;
        private string maDoanhThuNam;
        private string thang;
        private int soChuyenBay;
        private long doanhThu;

        public DTO_DoanhThuThang()
        {
        }
        public DTO_DoanhThuThang(string maDoanhThuThang, string maDoanhThuNam, string thang, int soChuyenBay, long doanhThu)
        {
            this.MaDoanhThuThang = maDoanhThuThang;
            this.MaDoanhThuNam = MaDoanhThuNam;
            this.Thang = thang;
            this.SoChuyenBay = soChuyenBay;
            this.DoanhThu = doanhThu;
        }

        public string MaDoanhThuNam { get => maDoanhThuNam; set => maDoanhThuNam = value; }
        public string MaDoanhThuThang { get => maDoanhThuThang; set => maDoanhThuThang = value; }
        public string Thang { get => thang; set => thang = value; }
        public int SoChuyenBay { get => soChuyenBay; set => soChuyenBay = value; }
        public long DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}
