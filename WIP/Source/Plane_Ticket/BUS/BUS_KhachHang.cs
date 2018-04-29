using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal = new DAL_KhachHang();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_KhachHang dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_KhachHang dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_KhachHang dto)
        {
            return dal.Delete(dto);
        }
    }
}
