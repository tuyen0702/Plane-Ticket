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
    public class BUS_GiaoDich
    {
        DAL_GiaoDich dal = new DAL_GiaoDich();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_GiaoDich dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_GiaoDich dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_GiaoDich dto)
        {
            return dal.Delete(dto);
        }
    }
}
