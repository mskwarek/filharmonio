using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBD1
{
    public static class Query
    {
        public static void nowaFilharmonia(NpgsqlConnection connection, string id, 
            string nazwa, string data_otwarcia, string imie_dyr, string nazwisko_dyr, 
            string ulica, string numer_lok, string nip, string regon)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT into Filharmonie(filharmonia_ID, nazwa, data_otwarcia, imie_dyrektora,"+
                "nazwisko_dyrektora, ulica, numer_lokalu , nip, regon)"+
                "VALUES ('"+id+"', '" +nazwa+"', '"+imie_dyr+"', '"+nazwisko_dyr+"', '"+ulica+"', '"+numer_lok
                +"', '"+nip+"', '"+regon+"');", connection);
        }
    }
}
