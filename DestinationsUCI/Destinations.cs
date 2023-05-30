using FinalPoject.DestinationsUCI;
using FinalPoject.FlightsUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.DestinationUCI
{
    public partial class Destinations : UserControl
    {
        public Destinations()
        {
            InitializeComponent();
        }





        private void guna2ButtonDubrovnik_Click(object sender, EventArgs e)
        {
            Dubrovnik dubrovnik=new Dubrovnik();
            dubrovnik.Show();
        }

        private void SANTORINI_Click(object sender, EventArgs e)
        {
            Santorini santorini = new Santorini();
            santorini.Show();
        }

        private void Algavre_Click(object sender, EventArgs e)
        {
           Portugalia portugalia = new Portugalia();
           portugalia.Show();
        }

        private void ROME_Click(object sender, EventArgs e)
        {
            Rome rome = new Rome();
            rome.Show();
        }

        private void MADRID_Click(object sender, EventArgs e)
        {
            Madrid madrid = new Madrid();   
            madrid.Show();
        }
    }
}
