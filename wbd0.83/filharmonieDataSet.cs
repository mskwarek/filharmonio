using Npgsql;
using System.Data;
namespace wbd0._83 {
    
    
    public partial class filharmonieDataSet {
        DataSet ds = new DataSet();

        public DataTable pobierzPracownicyObslugi(PsqlConnection connection)
        {
            string sql = "SELECT * FROM wbd.pracownicy_obslugi;";
            NpgsqlDataAdapter da = connection.ExecuteQuery(sql);
            ds.Reset();
            da.Fill(ds);
            //pracownicy_obslugiBindingSource 
            DataTable dt = ds.Tables[0];

            return dt;
        }
    }
}
