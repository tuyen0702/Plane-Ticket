using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoanhThuNam
    {
        private string maDoanhThuNam;
        private string nam;
        private long doanhThu;
        public DTO_DoanhThuNam()
        {
        }
        public DTO_DoanhThuNam(string maDoanhThuNam, string nam, long doanhThu)
        {
            this.MaDoanhThuNam = maDoanhThuNam;
            this.Nam = nam;
            this.DoanhThu = doanhThu;
        }

        public string MaDoanhThuNam { get => maDoanhThuNam; set => maDoanhThuNam = value; }
        public string Nam { get => nam; set => nam = value; }
        public long DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}
