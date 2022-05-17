using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon
{
    class Connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ERTNRK5\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
