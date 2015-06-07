using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms; 
namespace WBD1
{
    class PsqlManager
    {
        public NpgsqlConnection conn { get; set; }

        public PsqlManager(string user, string password)
        {
          
                // Specify connection options and open an connection
                conn = new NpgsqlConnection("Server=89.65.47.175;Port=5432;"+
                            "User Id="+user+";Password="+password+";Database=wbd;SSL=true;SslMode=Require;");
                conn.Open();

                // Define a query
               // NpgsqlCommand cmd = new NpgsqlCommand("select * from wbd.poczty", conn);
                //Query.nowaPoczta(conn, "3", "21422", "Stanin");
                //Query.nowaFilharmonia(conn, "2", "nazwa", "2015-01-01", "typowy", "typ", "ulica", "5", "1234567890", "123456789");
                TransactionManager trMen = new TransactionManager();
            /*
                Query.WykonajFunkcjeTrm(conn, "wbd.ins_poczty", trMen,
                    //new ParametrInfo("poczta_id", DbType.Int32, 3),
                    new ParametrInfo("kod_pocztowy", DbType.Decimal, 21422),
                    new ParametrInfo("miejscowosc", DbType.String, "Tuchowicz"));
            */
                // Execute a query
                //NpgsqlDataReader dr = cmd.ExecuteReader();

                // Read all rows and output the first column in each row
                //while (dr.Read())
                //    Console.Write("{0}\n", dr[0]);

                // Close connection
                //conn.Close();
     
        }
    }
}
