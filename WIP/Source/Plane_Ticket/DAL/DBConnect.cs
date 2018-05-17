using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=LAPTOP-LEEDDWCS\SQLEXPRESS;Initial Catalog=PLANE_TICKET_NEW;Integrated Security=True");

        public void Connect()
        {
            _con.Open();
        }

        public void Disconnect()
        {
            _con.Close();
        }
    }

    
}
