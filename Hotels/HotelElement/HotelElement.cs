using FinalPoject.HomeUCI;
using FinalPoject.HomeUCI.PanelButtonUser;
using FinalPoject.Hotels.HotelElement.HotelRooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.Hotels.HotelElement
{
    public partial class HotelElement : UserControl
    {
        private Hotel hotel;
        private int days;
        public Image SingleBed = Image.FromFile("C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\icons8-person-30\\SingleBed.png");
        public Image DoubleBed = Image.FromFile("C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\icons8-person-30\\DoubleBed.png");
        public HotelElement()
        {
            InitializeComponent();
        }

        public HotelElement(Hotel hotel,int days)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.days= days;
            PBHotelImage.Image = hotel.Images[0];
            LblHotelName.Text = hotel.Name;
            LblHotelAddress.Text = hotel.Address;
            int maxLength = 70; 

            if (LblHotelAddress.Text.Length > maxLength)
            {
                string truncatedAddress = LblHotelAddress.Text.Substring(0, maxLength) + "...";
                LblHotelAddress.Text = truncatedAddress;
            }
            else
            {
                LblHotelAddress.Text = LblHotelAddress.Text;
            }
            if (hotel.Rooms.Count > 0) {
                Room room=hotel.GetRoomWithLowestPrice();
                LblHotelRoom1.Text = room.RoomType.ToString();
                LblHotelRoomPrice.Text = Convert.ToString(hotel.Rooms[0].SelectedCurrency.Code + " " + room.PricePerNight* days);
                if(room.BedSize=="Double")
                {
                    PBHotelBed.Image = DoubleBed;
                }
                else
                {
                    PBHotelBed.Image = SingleBed;
                }
            }
            SetStars(hotel.Rating);
        }

        private void SetStars(int rating)
        {
            PBStar1.Visible = rating >= 1;
            PBStar2.Visible = rating >= 2;
            PBStar3.Visible = rating >= 3;
            PBStar4.Visible = rating >= 4;
            PBStar5.Visible = rating >= 5;
        }

        private void HotelElement_Load(object sender, EventArgs e)
        {

        }
        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PnlHotel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCheckAvailability_Click(object sender, EventArgs e)
        {
            HotelPage hotelPage = new HotelPage(hotel, days);
            HomeSignedIn.Instance.pnlAccount.Controls.Add(hotelPage);
            hotelPage.pnlContents.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location = new Point(654, 6);
            ButtonUser.Instance.BringToFront();
            hotelPage.BringToFront();
        }
    }
}
