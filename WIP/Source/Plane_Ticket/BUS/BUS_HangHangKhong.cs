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
    public class BUS_HangHangKhong
    {
        DAL_HangHangKhong dal = new DAL_HangHangKhong();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_HangHangKhong dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_HangHangKhong dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_HangHangKhong dto)
        {
            return dal.Delete(dto);
        }
    }
}
