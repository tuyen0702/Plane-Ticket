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
    public class DAL_DoanhThuThang:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM DOANHTHUTHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_DoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO DOANHTHUTHANG(MADOANHTHUTHANG, MADOANHTHUNAM, THANG, SOCHUYENBAY, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", dto.MaDoanhThuNam, dto.MaDoanhThuThang, dto.Thang, dto.SoChuyenBay, dto.DoanhThu);
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

        public bool Update(DTO_DoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE DOANHTHUTHANG SET MADOANHTHUTHANG='{0}', MADOANHTHUNAM='{1}', THANG='{2}', SOCHUYENBAY='{3}', DOANHTHU='{4}')", dto.MaDoanhThuNam, dto.MaDoanhThuThang, dto.Thang, dto.SoChuyenBay, dto.DoanhThu);
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
        public bool Delete(DTO_DoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM DOANHTHUTHANG WHERE MADOANHTHUTHANG='{0}'", dto.MaDoanhThuThang);
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
