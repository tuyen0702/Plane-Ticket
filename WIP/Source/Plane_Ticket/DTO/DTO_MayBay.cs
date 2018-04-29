using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MayBay
    {
        private string maMayBay;
        private string tenMayBay;
        private string maHHK;
        private int soLuongGheH1;
        private int soLuongGheH2;
        public DTO_MayBay()
        {
        }
        public DTO_MayBay(string maMayBay, string tenMayBay, string maHHK, int soLuongGheH1, int soLuongGheH2)
        {
            this.tenMayBay = maMayBay;
            this.tenMayBay = tenMayBay;
            this.maHHK = maHHK;
            this.soLuongGheH1 = soLuongGheH1;
            this.soLuongGheH2 = soLuongGheH2;
        }

        public string TenMayBay { get => TenMayBay1; set => TenMayBay1 = value; }
        public string TenMayBay1 { get => tenMayBay; set => tenMayBay = value; }
        public string MaHHK { get => maHHK; set => maHHK = value; }
        public int SoLuongGheH1 { get => soLuongGheH1; set => soLuongGheH1 = value; }
        public int SoLuongGheH2 { get => soLuongGheH2; set => soLuongGheH2 = value; }
        public string MaMayBay { get => maMayBay; set => maMayBay = value; }
    }
}
