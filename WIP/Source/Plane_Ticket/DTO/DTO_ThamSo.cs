using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThamSo
    {
        private DateTime thoiGianBayToiThieu;
        private int soSanBayTGToiDa;
        private DateTime thoiGianDungToiThieu;
        private DateTime thoiGianDungToiDa;
        private DateTime thoiGianChamNhatDatVe;
        private DateTime thoiGianChamNhatHuyVe;
        public DTO_ThamSo()
        {
        }
        public DTO_ThamSo(DateTime thoiGianBayToiThieu, int soSanBayTGToiDa, DateTime thoiGianDungToiThieu, DateTime thoiGianDungToiDa, DateTime thoiGianChamNhatDatVe, DateTime thoiGianChamNhatHuyVe)
        {
            this.ThoiGianBayToiThieu = thoiGianBayToiThieu;
            this.SoSanBayTGToiDa = soSanBayTGToiDa;
            this.ThoiGianDungToiThieu = thoiGianDungToiThieu;
            this.ThoiGianDungToiDa = thoiGianDungToiDa;
            this.ThoiGianChamNhatDatVe = thoiGianChamNhatDatVe;
            this.ThoiGianChamNhatHuyVe = thoiGianChamNhatHuyVe;
        }

        public int SoSanBayTGToiDa { get => soSanBayTGToiDa; set => soSanBayTGToiDa = value; }
        public DateTime ThoiGianChamNhatDatVe { get => thoiGianChamNhatDatVe; set => thoiGianChamNhatDatVe = value; }
        public DateTime ThoiGianChamNhatHuyVe { get => thoiGianChamNhatHuyVe; set => thoiGianChamNhatHuyVe = value; }
        public DateTime ThoiGianDungToiThieu { get => thoiGianDungToiThieu; set => thoiGianDungToiThieu = value; }
        public DateTime ThoiGianBayToiThieu { get => thoiGianBayToiThieu; set => thoiGianBayToiThieu = value; }
        public DateTime ThoiGianDungToiDa { get => thoiGianDungToiDa; set => thoiGianDungToiDa = value; }
    }
}
