using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDUD
{
   public class SqlBaglanti
    {
 

        public SqlConnection Baglan()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS02;Initial Catalog=WDUDatabase;Integrated Security=True");
            if (baglanti.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Open();
                }
                catch
                {
           
                }
            }
            return baglanti;
        }

        public bool İşlemYap(string sql)
        {
            SqlCommand kmt = new SqlCommand(sql, Baglan());
            if (kmt.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public object FunctionÇağır(string sql)
        {
            SqlCommand kmt = new SqlCommand(sql, Baglan());
            return kmt.ExecuteScalar();
        }

        public  DataTable TabloSorgula(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Baglan());
            DataSet data = new DataSet();
            adap.Fill(data);
            return data.Tables[0];
        }

        
    }
}
