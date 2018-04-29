using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TuyenBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM TUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_TuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO TUYENBAY(MASANBAYDI, MASANBAYDEN, MASANBAYTG, THOIGIANNGHI, THOIGIANBAY) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", dto.MaTuyenBay, dto.MaSanBayDi, dto.MaSanBayDen, dto.MaSanBayTG, dto.ThoiGianNghi, dto.ThoiGianBay);
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

        public bool Update(DTO_TuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE TUYENBAY SET MASANBAYDI='{0}', MASANBAYDEN='{1}', MASANBAYTG='{2}', THOIGIANNGHI='{3}', THOIGIANBAY='{4}')", dto, dto.MaSanBayDi, dto.MaSanBayDen, dto.MaSanBayTG, dto.ThoiGianNghi, dto.ThoiGianBay);
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
        public bool Delete(DTO_TuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM CHUYENBAY WHERE MATUYENBAY='{0}'", dto.MaTuyenBay);
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
