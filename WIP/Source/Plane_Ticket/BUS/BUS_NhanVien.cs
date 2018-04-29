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
    public class BUS_NhanVien
    {
        DAL_NhanVien dal = new DAL_NhanVien();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_NhanVien dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_NhanVien dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_NhanVien dto)
        {
            return dal.Delete(dto);
        }
    }
}
