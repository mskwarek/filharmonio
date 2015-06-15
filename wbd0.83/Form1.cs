using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wbd0._83
{
    public partial class Form1 : Form
    {
        public PsqlConnection connection;
        private PrzyciskiMenu przyciski;

        public Form1()
        {
            InitializeComponent();
           // connection = new PsqlConnection("adam", "szwagier1");

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraNavBar.NavBarControl control = (DevExpress.XtraNavBar.NavBarControl)sender;
            //control.
            try
            {
                string name = control.PressedLink.ItemName;
                switch (name)
                {
                    case "pracownicy_obslugi":
                        var page = new DevExpress.XtraTab.XtraTabPage();
                        page.Text = "Pracownicy obslugi";
                        PracownicyObslugi uc = new PracownicyObslugi();
                        uc.Dock = DockStyle.Fill;
                        page.Controls.Add(uc);
                        tableView.TabPages.Add(page);
                        this.tableView.SelectedTabPage = page;
                        przyciski = uc;
                        break;

                }
            }
            //Console.WriteLine(this.nawigacja.SelectedLink.Caption);
            catch { }

        }



        private void tableView_CloseButtonClick(object sender, System.EventArgs e)
        {
            tableView.TabPages.Remove(tableView.SelectedTabPage);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            przyciski.Dodaj();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            przyciski.Usun();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            przyciski.Edytuj();
        }

    }
}
