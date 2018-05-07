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
    public class BUS_VeChuyenBay
    {
        DAL_VeChuyenBay dal = new DAL_VeChuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_VeChuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_VeChuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_VeChuyenBay dto)
        {
            return dal.Delete(dto);
        }
    }
}
