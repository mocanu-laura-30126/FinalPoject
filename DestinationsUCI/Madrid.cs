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
    public partial class Madrid : Form
    {
        public Madrid()
        {
            InitializeComponent();
        }

        private void guna2ButtonMadClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonMadminus3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonMadClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonMadminus2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ButtonMadClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
