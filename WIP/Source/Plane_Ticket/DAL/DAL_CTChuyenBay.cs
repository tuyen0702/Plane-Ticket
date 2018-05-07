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
    public class DAL_CTChuyenBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM CTCHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_CTChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO CTCHUYENBAY(MACHUYENBAY, MASANBAYTG, THOIGIANDUNG, GHICHU) VALUES('{0}', '{1}', '{2}', '{3}')", dto.MaChuyenBay, dto.MaSanBayTG, dto.ThoiGianDung, dto.GhiChu);
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

        public bool Update(DTO_CTChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE CTCHUYENBAY SET MACHUYENBAY='{0}', MASANBAYTG='{1}', THOIGIANDUNG='{2}', GHICHU='{3}')", dto.MaChuyenBay, dto.MaSanBayTG, dto.ThoiGianDung, dto.GhiChu);
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
        public bool Delete(DTO_CTChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM CTCHUYENBAY WHERE MACHUYENBAY='{0}' AND MASANBAYTG='{1}'", dto.MaChuyenBay, dto.MaSanBayTG);
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

        public DataTable TimSanBayTGCuaChuyenBay(string maChuyenBay)
        {
            string sqlQuery = string.Format("SELECT* FROM CTCHUYENBAY WHERE MACHUYENBAY='{0}'", maChuyenBay);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery,_con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
