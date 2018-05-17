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
    public class DAL_CTDoanhThuThang:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM CTDOANHTHUTHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_CTDoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO CTDOANHTHUTHANG(MADOANHTHUTHANG, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", dto.MaDoanhThuThang, dto.MaChuyenBay, dto.SoVeBanDuoc, dto.DoanhThu);
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

        public bool Update(DTO_CTDoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE CTDOANHTHUTHANG SET MADOANHTHUTHANG='{0}', MACHUYENBAY='{1}', SOVEBANDUOC='{2}', DOANHTHU='{3}')", dto.MaDoanhThuThang, dto.MaChuyenBay, dto.SoVeBanDuoc, dto.DoanhThu);
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
        public bool Delete(DTO_CTDoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM CTDOANHTHUTHANG WHERE MADOANHTHUTHANG='{0}' AND MACHUYENBAY='{1}'", dto.MaDoanhThuThang, dto.MaChuyenBay);
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
