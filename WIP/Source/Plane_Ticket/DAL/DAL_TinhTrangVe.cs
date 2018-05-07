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
    public class DAL_TinhTrangVe:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM TINHTRANGVE";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_TinhTrangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO TINHTRANGVE(MACHUYENBAY, MAHANGVE, TONGSOGHE, SOGHETRONG) VALUES('{0}', '{1}', '{2}', '{3}')", dto.MaChuyenBay, dto.MaHangVe, dto.TongSoGhe, dto.SoGheTrong);
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

        public bool Update(DTO_TinhTrangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE TINHTRANGVE SET MACHUYENBAY='{0}', MAHANGVE='{1}', TONGSOGHE='{2}', SOGHETRONG='{3}')", dto.MaChuyenBay, dto.MaHangVe, dto.TongSoGhe, dto.SoGheTrong);
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
        public bool Delete(DTO_TinhTrangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM TINHTRANGVE WHERE MACHUYENBAY='{0}' AND MAHANGVE='{1}'", dto.MaChuyenBay, dto.MaHangVe);
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

        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            DataTable dt = new DataTable();
            string strQuery = string.Format("SELECT* FROM TINHTRANGVE T INNER JOIN HANGVE H " +
                "ON T.MAHANGVE=H.MAHANGVE WHERE T.MACHUYENBAY='{0}'", maChuyenBay);
            SqlDataAdapter da = new SqlDataAdapter(strQuery, _con);
            da.Fill(dt);
            return dt;
        }
    }
}
