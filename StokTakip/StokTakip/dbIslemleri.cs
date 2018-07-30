using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StokTakip
{
    class dbIslemleri
    {
        private SqlConnection baglan;
           public SqlConnection baglanti()
        {
            baglan = new SqlConnection("Data Source=DESKTOP-163F0GR;Initial Catalog=StokTakip;Integrated Security=True");
            if (baglan==null)
            baglan = new SqlConnection("Data Source=DESKTOP-163F0GR;Initial Catalog=StokTakip;Integrated Security=True");
            if(baglan.State==System.Data.ConnectionState.Closed)
            baglan.Open();
            return baglan;
        }
    }
}
