using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wbd0._83
{
    public class PsqlConnection
    {
        public static NpgsqlConnection conn { get; set; }

        public PsqlConnection(string user, string password)
        {

            // Specify connection options and open an connection
            conn = new NpgsqlConnection("Server=89.65.47.175;Port=5432;" +
                        "User Id=" + user + ";Password=" + password + ";Database=wbd;SSL=true;SslMode=Require;");
            conn.Open();
        }

        public NpgsqlDataAdapter ExecuteQuery(string query)
        {
            return new NpgsqlDataAdapter(query, conn);
        }

        public void endConnection()
        {
            conn.Close();
        }
    }
}
