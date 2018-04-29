using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        public DTO_NhanVien()
        {
        }
        public DTO_NhanVien(string maNhanVien, string tenNhanVien)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
        }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
    }
}
