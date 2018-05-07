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
    public class DAL_VeChuyenBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM VECHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_VeChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO VECHUYENBAY(MAVE, MACHUYENBAY, MAHANGVE, GIATIEN, TINHTRANGVE, NGAYHUY) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", dto.MaChuyenBay, dto.MaHangVe, dto.GiaTien, dto.TinhTrang, dto.NgayHuy);
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

        public bool Update(DTO_VeChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE VECHUYENBAY SET MACHUYENBAY='{0}', MAHANGVE='{1}', GIATIEN='{2}', TINHTRANGVE='{3}', NGAYHUY='{4}', MAVE='{5}')", dto.MaChuyenBay, dto.MaHangVe, dto.GiaTien, dto.TinhTrang, dto.NgayHuy, dto.MaVe);
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
        public bool Delete(DTO_VeChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM VECHUYENBAY WHERE MAVE='{0}'", dto.MaVe);
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
