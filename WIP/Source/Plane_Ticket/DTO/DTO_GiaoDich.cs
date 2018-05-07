using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoDich
    {
        private string maVe;
        private string maKhachHang;
        private string maNhanVien;
        private DateTime ngayGioGD;
        private string hinhThucTT;
        private string tinhTrangTT;

        public DTO_GiaoDich()
        {
        }
        public DTO_GiaoDich(string maVe, string maKhachHang, string maNhanVien, DateTime ngayGioGD, string hinhThucTT, string tinhTrangTT)
        {
            this.maVe = maVe;
            this.maKhachHang = maKhachHang;
            this.MaNhanVien = maNhanVien;
            this.NgayGioGD = ngayGioGD;
            this.hinhThucTT = hinhThucTT;
            this.tinhTrangTT = tinhTrangTT;
        }

        public string MaVe { get => maVe; set => maVe = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HinhThucTT { get => hinhThucTT; set => hinhThucTT = value; }
        public string TinhTrangTT { get => tinhTrangTT; set => tinhTrangTT = value; }
        public DateTime NgayGioGD { get => ngayGioGD; set => ngayGioGD = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
