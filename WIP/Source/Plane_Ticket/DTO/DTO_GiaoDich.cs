using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoDich
    {
        private string maGiaoDich;
        private string maVe;
        private string maKhachHang;
        private string maNhanVien;
        private DateTime ngayGioGD;
        private string hinhThucTT;
        private string tinhTrangTT;

        public DTO_GiaoDich()
        {
        }
        public DTO_GiaoDich(string maGiaoDich, string maVe, string maKhachHang, string maNhanVien, DateTime ngayGioGD, string hinhThucTT, string tinhTrangTT)
        {
            this.maGiaoDich = maGiaoDich;
            this.maVe = maVe;
            this.maKhachHang = maKhachHang;
            this.maNhanVien = maNhanVien;
            this.NgayGioGD = ngayGioGD;
            this.hinhThucTT = hinhThucTT;
            this.tinhTrangTT = tinhTrangTT;
        }

        public string MaGiaoDich { get => maGiaoDich; set => maGiaoDich = value; }
        public string MaVe { get => maVe; set => maVe = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HinhThucTT { get => hinhThucTT; set => hinhThucTT = value; }
        public string TinhTrangTT { get => tinhTrangTT; set => tinhTrangTT = value; }
        public DateTime NgayGioGD { get => ngayGioGD; set => ngayGioGD = value; }
    }
}
