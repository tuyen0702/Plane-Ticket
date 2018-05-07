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
    public class DAL_HangVe:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM HANGVE";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_HangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO HANGVE(MAHANGVE, TENHANGVE) VALUES('{0}', N'{1}')", dto.MaHangVe, dto.TenHangVe);
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

        public bool Update(DTO_HangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE HANGVE SET MAHANGVE='{0}', TENHANGVE='{1}')", dto.MaHangVe, dto.TenHangVe);
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
        public bool Delete(DTO_HangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM HANGVE WHERE MAHANGVE='{0}'", dto.MaHangVe);
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
