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
    public class BUS_MayBay
    {
        DAL_MayBay dal = new DAL_MayBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_MayBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_MayBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_MayBay dto)
        {
            return dal.Delete(dto);
        }
    }
}
