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
    public partial class Rome : Form
    {
        public Rome()
        {
            InitializeComponent();
        }

        private void guna2Romeminus3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonRomeclose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonRomeminus2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonRomeclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonRomeminus1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonRomeclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
