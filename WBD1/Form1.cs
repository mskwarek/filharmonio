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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();       
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            PsqlManager manager = new PsqlManager(this.textBox1.Text, this.password.Text);
            Program.app = new applicationForm(manager.conn);
            this.Close();
        }
    }
}
