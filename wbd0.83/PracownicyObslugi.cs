using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wbd0._83
{
    public partial class PracownicyObslugi : UserControl, PrzyciskiMenu
    {
        filharmonieDataSet dataSet;
            
        public PracownicyObslugi()
        {
            InitializeComponent();

            PsqlConnection connection = new PsqlConnection("adam", "szwagier1");
            dataSet = new filharmonieDataSet();
            DataTable table = dataSet.pobierzPracownicyObslugi(connection);
            //filharmonieDataSet.praco
            this.pracownicyobslugiBindingSource.DataSource = table;
            

            //this.gridControl1.DataSource = table;
            
        }

        public void Dodaj()
        {
            
        }

        public void Usun()
        {
            
        }

        public void Edytuj()
        {
            
        }
    }
}
