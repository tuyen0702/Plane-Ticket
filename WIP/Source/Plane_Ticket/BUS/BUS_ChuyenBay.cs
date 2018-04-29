using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_ChuyenBay
    {
        DAL_ChuyenBay dal = new DAL_ChuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_ChuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_ChuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_ChuyenBay dto)
        {
            return dal.Delete(dto);
        }
    }
}
