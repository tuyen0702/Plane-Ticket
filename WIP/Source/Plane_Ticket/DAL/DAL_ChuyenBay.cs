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
                string sqlQuery = string.Format("INSERT INTO CHUYENBAY(MATUYENBAY, MAMAYBAY, THOIGIANKHOIHANH, THOIGIANKETTHUC) VALUES('{0}', '{1}', '{2}', '{3}')",dto.MaTuyenBay, dto.MaMayBay, dto.ThoiGianKhoiHanh, dto.ThoiGianKetThuc);
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
                string sqlQuery = string.Format("UPDATE CHUYENBAY SET MATUYENBAY='{0}', MAMAYBAY='{1}', THOIGIANKHOIHANH='{2}', THOIGIANKETTHUC='{3}')", dto.MaTuyenBay, dto.MaMayBay, dto.ThoiGianKhoiHanh, dto.ThoiGianKetThuc);
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
    }
}
