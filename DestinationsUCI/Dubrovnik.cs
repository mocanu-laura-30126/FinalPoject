using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.DestinationsUCI
{
    public partial class Dubrovnik : Form
    {
        public Dubrovnik()
        {
            InitializeComponent();
        }
       
       
        private void guna2ButtonDubminus1_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonDubclose1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2ButtonDubminus2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonDubclose2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonDubminus3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonDubclose3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
