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
    public class DAL_NhanVien:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_NhanVien dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO NHANVIEN(MANHANVIEN, TENNHANVIEN) VALUES('{0}', '{1}')", dto.MaNhanVien, dto.TenNhanVien);
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

        public bool Update(DTO_NhanVien dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE NHANVIEN SET TENNHANVIEN='{0}', MANHANVIEN='{1}')", dto.TenNhanVien, dto.MaNhanVien);
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
        public bool Delete(DTO_NhanVien dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM NHANVIEN WHERE MANHANVIEN='{0}'", dto.MaNhanVien);
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
