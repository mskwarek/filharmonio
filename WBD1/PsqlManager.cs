using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql; 
namespace WBD1
{
    class PsqlManager
    {

        public PsqlManager()
        {
          
                // Specify connection options and open an connection
                NpgsqlConnection conn = new NpgsqlConnection("Server=ec2-54-247-79-142.eu-west-1.compute.amazonaws.com;Port=5432;"+
                            "User Id=scwsyxapuubtqw;Password=H0ROhcTkKnUSyWzox2M5Xc9gi1;Database=df2q62t1b26udq;SSL=true;SslMode=Require;");
                conn.Open();

                // Define a query
                NpgsqlCommand cmd = new NpgsqlCommand("select * from filharmonie", conn);
                Query.nowaFilharmonia(conn, "2", "nazwa", "2015-01-01", "typowy", "typ", "ulica", "5", "1234567890", "123456789");

                // Execute a query
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Read all rows and output the first column in each row
                while (dr.Read())
                    Console.Write("{0}\n", dr[0]);

                // Close connection
                conn.Close();
     
        }
    }
}
