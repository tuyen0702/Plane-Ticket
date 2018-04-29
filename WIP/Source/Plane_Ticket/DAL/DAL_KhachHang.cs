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
    public class DAL_KhachHang:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_KhachHang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO KHACHHANG(TENKHACHHANG, CMND, SDT) VALUES('{0}', '{1}', '{2}')", dto.TenKhachHang, dto.CMND1, dto.SDT1);
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

        public bool Update(DTO_KhachHang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE KHACHHANG SET TENKHACHHANG='{0}', CMND='{1}', SDT='{2}')", dto.TenKhachHang, dto.CMND1, dto.SDT1);
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
        public bool Delete(DTO_KhachHang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM KHACHHANG WHERE MAKHACHHANG='{0}'", dto.MaKhachHang);
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
