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
    public partial class Portugalia : Form
    {
        public Portugalia()
        {
            InitializeComponent();
        }

        private void Portugalia_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1minus1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
