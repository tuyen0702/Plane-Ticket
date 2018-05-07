using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_ChuyenBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM CHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_ChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO CHUYENBAY(MACHUYENBAY, MATUYENBAY, MAMAYBAY, THOIGIANKHOIHANH, THOIGIANBAY) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",dto.MaChuyenBay, dto.MaTuyenBay, dto.MaMayBay, dto.ThoiGianKhoiHanh, dto.ThoiGianBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }

        public bool Update(DTO_ChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE CHUYENBAY SET MACHUYENBAY='{0}', MATUYENBAY='{1}', MAMAYBAY='{2}', THOIGIANKHOIHANH='{3}', THOIGIANBAY='{4}')", dto.MaChuyenBay, dto.MaTuyenBay, dto.MaMayBay, dto.ThoiGianKhoiHanh, dto.ThoiGianBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if(cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }
            }
            catch(Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Delete(DTO_ChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM CHUYENBAY WHERE MACHUYENBAY='{0}'",dto.MaChuyenBay);
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
            string sqlQuery = string.Format("SELECT * FROM CHUYENBAY C INNER JOIN TUYENBAY T " +
                "ON C.MATUYENBAY=T.MATUYENBAY WHERE MACHUYENBAY='{0}'", maChuyenBay);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            da.Fill(dt);
            return dt;
        }
    }
}
