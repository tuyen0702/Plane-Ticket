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
    public class DAL_GiaoDich : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM GIAODICH";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_GiaoDich dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO GIAODICH(MAVE, MAKHACHHANG, MANHANVIEN, NGAYGIOGD, HINHTUCGD, TINHTRANGGD) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", dto.MaVe, dto.MaNhanVien, dto.MaNhanVien, dto.NgayGioGD, dto.HinhThucTT, dto.TinhTrangTT);
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

        public bool Update(DTO_GiaoDich dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE GIAODICH SET MAVE='{0}', MAKHACHHANG='{1}', MANHANVIEN='{2}', NGAYGIOGD='{3}', HINHTHUCGD='{4}', TINHTRANGGD='{5)", dto.MaVe, dto.MaKhachHang, dto.MaNhanVien, dto.NgayGioGD, dto.HinhThucTT, dto.TinhTrangTT);
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
        public bool Delete(DTO_GiaoDich dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM GIAODICH WHERE MAGIAODICH='{0}'", dto.MaGiaoDich);
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
