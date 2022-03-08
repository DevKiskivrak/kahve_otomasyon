using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace kahve_otomasyon
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C45MJKA\SQLEXPRESS;Initial Catalog=kahve_otomasyon;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
