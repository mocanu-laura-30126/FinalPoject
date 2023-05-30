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

namespace FinalPoject.HomeUCI.Account.Bookings.RoomBooking
{
    public partial class RoomBookingElement : UserControl
    {
        public Room room;
        public RoomBookingElement()
        {
            InitializeComponent();
        }
        public Guna2TextBox txtBHotelName
        {
            get { return TxtBoxHotelName; }
            set { TxtBoxHotelName = value; }
        }

        public Guna2TextBox txtBRoomNumber
        {
            get { return TxtBoxRoomNumber; }
            set { TxtBoxRoomNumber = value; }
        }

        public RoomBookingElement(String hotelName, Room room,
            decimal totalCost, string currencyCode, DateTime checkIn, DateTime checkOut)
        {
            InitializeComponent();
            this.room= room;
            SetRoomElement(hotelName, room, totalCost, currencyCode, checkIn, checkOut);

        }
        private void SetRoomElement(String hotelName, Room room, decimal totalCost,
            string currencyCode, DateTime checkIn, DateTime checkOut)
        {
            PBRoom.Image = room.RoomImages[0];
            TxtBoxHotelName.Text = hotelName;
            TxtBoxRoomNumber.Text = Convert.ToString(room.Number);
            TxtBoxRoomSize.Text = Convert.ToString(room.Size);
            TxtBoxRoomType.Text = Convert.ToString(room.RoomType);
            TxtBoxTotalCost.Text = Convert.ToString(totalCost) + " " + currencyCode;
            TxtBoxCheckIn.Text = Convert.ToString(checkIn);
            TxtBoxCheckOut.Text = Convert.ToString(checkOut);
        }
        private void PBRoom_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtBoxHotelName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
