using FinalPoject.HomeUCI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.Hotels.HotelElement.HotelRooms
{
    public partial class HotelPage : UserControl
    {
        public Hotel hotel;
        private int days;
        public HotelPage()
        {
            InitializeComponent();
        }
        public HotelPage(Hotel hotel, int days)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.days = days;
        }
        public Panel pnlContents
        {
            get { return PnlContents; }
            set { PnlContents = value; }
        }
        private void HotelPage_Load(object sender, EventArgs e)
        {
            SetHotel();

        }
        private void SetHotel()
        {
            LblHotelName.Text = hotel.Name;
            LblAddress.Text = hotel.Address;
            LblDescription.Text = hotel.Description;
            SetStars(hotel.Rating);
            if (hotel.Images.Count >= 1)
            {
                PBHotel1.Image = hotel.Images[0];
                PBHotel1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                PBHotel1.Image = null;

            if (hotel.Images.Count >= 2)
            {
                PBHotel2.Image = hotel.Images[1];
                PBHotel2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                PBHotel2.Image = null;

            if (hotel.Images.Count >= 3)
            {
                PBHotel3.Image = hotel.Images[2];
                PBHotel3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                PBHotel3.Image = null;

            foreach (Room room in hotel.Rooms)
            {
                RoomElement roomCreated = new RoomElement(room, days);
                this.PnlContents.Controls.Add(roomCreated);
                roomCreated.Dock = DockStyle.Bottom;
            }
        }
        private void SetStars(int rating)
        {
            PBStar1.Visible = rating >= 1;
            PBStar2.Visible = rating >= 2;
            PBStar3.Visible = rating >= 3;
            PBStar4.Visible = rating >= 4;
            PBStar5.Visible = rating >= 5;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Remove(this);
        }
    }
}
