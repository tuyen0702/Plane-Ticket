using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HangHangKhong
    {
        private string maHHK;
        private string tenHHK;

        public DTO_HangHangKhong()
        {
        }

        public DTO_HangHangKhong(string maHHK, string tenHHK)
        {
            this.maHHK = maHHK;
            this.tenHHK = tenHHK;
        }

        public string MaHHK { get => maHHK; set => maHHK = value; }
        public string TenHHK { get => tenHHK; set => tenHHK = value; }
    }
}
