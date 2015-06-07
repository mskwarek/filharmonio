using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBD1
{
    public partial class applicationForm : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public applicationForm(NpgsqlConnection conn)
        {
            InitializeComponent();
            string sql = "select * from wbd.poczty;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            // i always reset DataSet before i do
            // something with it.... i don't know why :-)
            ds.Reset();
            // filling DataSet with result from NpgsqlDataAdapter
            da.Fill(ds);
            // since it C# DataSet can handle multiple tables, we will select first
            dt = ds.Tables[0];
            // connect grid to DataTable
            dataGridView1.DataSource = dt;
        }
    }
}
