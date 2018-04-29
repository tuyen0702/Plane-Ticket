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
    public class BUS_TuyenBay
    {
        DAL_TuyenBay dal = new DAL_TuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_TuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_TuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_TuyenBay dto)
        {
            return dal.Delete(dto);
        }
    }
}
