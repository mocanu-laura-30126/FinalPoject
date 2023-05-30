using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.Hotels.HotelElement.HotelRooms
{
    public partial class RoomElement : UserControl
    {
        private int days;
        private Room room;
        public Image SingleBed = Image.FromFile("C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\icons8-person-30\\SingleBed.png");
        public Image DoubleBed = Image.FromFile("C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\icons8-person-30\\DoubleBed.png");
        public RoomElement()
        {
            InitializeComponent();
        }
        public RoomElement(Room room, int days)
        {
            InitializeComponent();
            this.room = room;
            this.days = days;
            SetRoom();
        }
        private void SetRoom()
        {
            LblRoomName.Text = room.RoomType.ToString();
            LblRoomSize.Text = room.Size + " m^2";
            if (room.BedSize == "Single")
            {
                PBBedType.Image = SingleBed;
                LblBedType.Text = "x" + room.NumberOfBeds + " Single Bed";
            }
            else
            {
                PBBedType.Image = DoubleBed;
                LblBedType.Text = "x" + room.NumberOfBeds + " Queen Bed";
            }
            Decimal totalPrice = Math.Round(room.PricePerNight, 2);
            LblPrice.Text = Convert.ToString(room.SelectedCurrency.Code + " " + totalPrice * days);
            if (room.RoomImages.Count >= 1)
            {
                PBRoom.Image = room.RoomImages[0];
                PBRoom.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
                PBRoom.Image = null;
        }
        private void BtnReserveRoom_Click(object sender, EventArgs e)
        {
            if (MainMenu.User != null && !checkRoomAvailable(room.RoomID, SearchHotel.Instance.getCheckIn(), SearchHotel.Instance.getCheckOut()))
            {
                try
                {
                    TimeSpan difference = SearchHotel.Instance.getCheckOut().Subtract(SearchHotel.Instance.getCheckIn());
                    int numberOfDays = difference.Days;

                    string insertQuery = "INSERT INTO [dbo].[RoomReservation] (RoomID, UserID, CheckIn, CheckOut, Cost,CurrencyCode) VALUES (@RoomID, @UserID, @CheckIn, @CheckOut, @Cost,@CurrencyCode)";
                    SqlCommand command = new SqlCommand(insertQuery, Login.myCon);
                    command.Parameters.AddWithValue("@RoomID", this.room.RoomID);
                    command.Parameters.AddWithValue("@UserID", MainMenu.User.UserID);
                    command.Parameters.AddWithValue("@CheckIn", SearchHotel.Instance.getCheckIn());
                    command.Parameters.AddWithValue("@CheckOut", SearchHotel.Instance.getCheckOut());
                    command.Parameters.AddWithValue("@Cost", numberOfDays * room.PricePerNight);
                    command.Parameters.AddWithValue("@CurrencyCode", room.SelectedCurrency.Code);

                    Login.myCon.Open();
                    command.ExecuteNonQuery();
                    Login.myCon.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
        private Boolean checkRoomAvailable(int RoomID, DateTime CheckIn, DateTime CheckOut)
        {
            Boolean result = false;
            using (SqlConnection connection = new SqlConnection(Login.myCon.ConnectionString))
            {
                string selectQuery = "SELECT RoomID, CheckIn, CheckOut FROM RoomReservation";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int roomID = (int)reader["RoomID"];
                        DateTime checkIn = (DateTime)reader["CheckIn"];
                        DateTime checkOut = (DateTime)reader["CheckOut"];
                        if (roomID == room.RoomID && checkIn.Equals(CheckIn) && checkOut.Equals(CheckOut))
                        {
                            result = true;
                        }
                    }
                    reader.Close();
                }
            }
            return result;

        }
    }
}
