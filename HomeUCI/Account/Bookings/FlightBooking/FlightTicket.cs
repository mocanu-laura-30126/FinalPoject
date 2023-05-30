using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.HomeUCI.Account.Bookings.FlightBooking
{
    public partial class FlightTicket : UserControl
    {
        public FlightTicket()
        {
            InitializeComponent();
        }

        public Guna2TextBox txtBoxPassengerName
        {
            get { return TxtBoxPassengerName; }
            set { TxtBoxPassengerName = value; }
        }

        public Guna2TextBox txtBoxOrigin
        {
            get { return TxtBoxOrigin; } 
            set {  TxtBoxOrigin = value;}  
        }

        public FlightTicket(String name,String origin,String destination
            ,DateTime dateDeparture,DateTime dateReturn,String price)
        {
            InitializeComponent();
            setTicket( name,  origin,  destination, dateDeparture,  dateReturn,  price);
        }

        private void setTicket(String name, String origin, String Destination
            , DateTime dateDeparture, DateTime dateReturn, String price)
        {
            TxtBoxPassengerName.Text = name;
            TxtBoxOrigin.Text = origin;
            TxtBoxDestination.Text = Destination;
            TxtBoxPrice.Text = price;
            TxtBoxDepartureDate.Text=dateDeparture.Date.ToString();
            TxtBoxReturnDate.Text= dateReturn.Date.ToString();
        }

        private void TxtBoxPassengerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
