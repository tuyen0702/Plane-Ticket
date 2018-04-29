using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanBay
    {
        private string maSanBay;
        private string tenSanBay;

        public DTO_SanBay()
        {
        }

        public DTO_SanBay(string maSanBay, string tenSanBay)
        {
            this.maSanBay = maSanBay;
            this.tenSanBay = maSanBay;
        }

        public string MaSanBay { get => maSanBay; set => maSanBay = value; }
        public string TenSanBay { get => tenSanBay; set => tenSanBay = value; }
    }
}
