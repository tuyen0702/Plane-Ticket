using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MayBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM MAYBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO MAYBAY(TENMAYBAY, SOLUONGGHE, MAMAYBAY) VALUES('{0}', '{1}', '{2}')", dto.TenMayBay, dto.SoLuongGhe, dto.MaMayBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }

        public bool Update(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE MAYBAY SET TENMAYBAY='{0}', SOLUONGGHE='{1}', MAMAYBAY='{2}')", dto.TenMayBay, dto.SoLuongGhe, dto.MaMayBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Delete(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM MAYBAY WHERE MAMAYBAY='{0}'", dto.MaMayBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
    }
}
