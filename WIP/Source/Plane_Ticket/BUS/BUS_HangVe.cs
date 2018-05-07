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
    public class BUS_HangVe
    {
        DAL_HangVe dal = new DAL_HangVe();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_HangVe dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_HangVe dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_HangVe dto)
        {
            return dal.Delete(dto);
        }
    }
}
