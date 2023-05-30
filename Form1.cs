using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject
{
    public partial class Form1 : Form
    {
        private List<Hotel> hotelList;
        private const int cGrip = 16;
        private const int cCaption = 32;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(DataAccess data)
        {
            InitializeComponent();
            hotelList = data.GetHotels();
            foreach(var element in  hotelList)
            {
                LBHotels.Items.Add(element);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void addElements()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void LblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void PBHotel1_Click(object sender, EventArgs e)
        {

        }

        private void LBHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBHotels.SelectedIndex != -1)
            {
                Hotel selectedHotel = (Hotel)LBHotels.SelectedItem;
                LBRooms.Items.Clear();
                foreach(var element in hotelList)

                TBHotelID.Text = selectedHotel.HotelID.ToString();
                TBHotelName.Text = selectedHotel.Name;
                TBHotelDescription.Text = selectedHotel.Description;
                TBHotelAddress.Text = selectedHotel.Address;
                TBHotelCity.Text = selectedHotel.City;
                TBHotelNrRooms.Text = selectedHotel.NumberOfRooms.ToString();
                TBHotelRating.Text = selectedHotel.Rating.ToString();

                if (selectedHotel.Images.Count >= 1)
                {
                    PBHotel1.Image = selectedHotel.Images[0];
                    PBHotel1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    PBHotel1.Image = null;

                if (selectedHotel.Images.Count >= 2)
                {
                    PBHotel2.Image = selectedHotel.Images[1];
                    PBHotel2.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    PBHotel2.Image = null;

                if (selectedHotel.Images.Count >= 3)
                {
                    PBHotel3.Image = selectedHotel.Images[2];
                    PBHotel3.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    PBHotel3.Image = null;

                LBRooms.Items.Clear();
                foreach (Room room in selectedHotel.Rooms)
                {
                    LBRooms.Items.Add(room);
                }
            }
        }

        private void TBHotelAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBRooms.SelectedIndex != -1)
            {
                Room selectedRoom = (Room)LBRooms.SelectedItem;

                TBRoomID.Text = selectedRoom.RoomID.ToString();
                TBRoomType.Text = selectedRoom.RoomType;
                TBRoomNr.Text = selectedRoom.Number.ToString();
                TBRoomDescription.Text = selectedRoom.Description;
                TBRoomPrice.Text = selectedRoom.PricePerNight.ToString();
                TBRoomNrBeds.Text = selectedRoom.NumberOfBeds.ToString();
                TBRoomSize.Text = selectedRoom.Size.ToString();

                if (selectedRoom.RoomImages.Count >= 1)
                {
                    PBRoom1.Image = selectedRoom.RoomImages[0];
                    PBRoom1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    PBRoom1.Image = null;

                if (selectedRoom.RoomImages.Count >= 2)
                {
                    PBRoom2.Image = selectedRoom.RoomImages[1];
                    PBRoom2.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    PBRoom2.Image = null;
            }
        }


    }
}
