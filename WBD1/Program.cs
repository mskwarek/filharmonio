using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBD1
{
    static class Program
    {
        public static applicationForm app;
        static Form1 logg;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            logg = new Form1();
            logg.ShowDialog();
            //logg.Close();
            //Application.Exit();
            Application.Run(app);
        }
    }
}
