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
    public class DAL_HangHangKhong:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM HANGHANGKHONG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_HangHangKhong dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO HANGHANGKHONG(TENHHK) VALUES('{0}')", dto.TenHHK);
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

        public bool Update(DTO_HangHangKhong dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE HANGHANGKHONG SET TENHHK='{0}')", dto.TenHHK);
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
        public bool Delete(DTO_HangHangKhong dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM HANGHANGKHONG WHERE MAHANGHANGKHONG='{0}'", dto.MaHHK);
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
