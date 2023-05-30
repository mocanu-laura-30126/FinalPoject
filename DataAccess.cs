using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class DataAccess
    {
        private string connectionString = "Data Source=DESKTOP-4RB4PAI\\SQLEXPRESS;Initial Catalog=TripWise;Integrated Security=True;"; // înlocuiește "YourConnectionString";
        
        public List<Hotel> GetHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Hotel";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int hotelID = (int)reader["HotelID"];
                            string name = (string)reader["Name"];
                            string description = (string)reader["Description"];
                            string address = (string)reader["Address"];
                            string city = (string)reader["City"];
                            int numberOfRooms = (int)reader["NumberOfRooms"];
                            int rating = (int)reader["Rating"];


                            List<Room> rooms = GetRoomsForHotel(hotelID);
                            Hotel hotel = new Hotel(hotelID, name, description, address, city, numberOfRooms, rating, rooms);
                            hotels.Add(hotel);
                        }
                    }
                }
            }

            return hotels;
        }

        public List<Room> GetRoomsForHotel(int hotelID)
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT r.*, h.Name AS HotelName FROM Room r INNER JOIN Hotel h ON r.HotelID = h.HotelID WHERE r.HotelID = @HotelID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HotelID", hotelID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roomID = (int)reader["RoomID"];
                            int number = (int)reader["Number"];
                            string roomType = (string)reader["RoomType"];
                            string description = (string)reader["Description"];
                            decimal pricePerNight = (decimal)reader["PricePerNight"];
                            int numberOfBeds = (int)reader["NumberOfBeds"];
                            double size = Convert.ToDouble(reader["Size"]);
                            string hotelName = (string)reader["HotelName"];

                            Room room = new Room(roomID, number, roomType, description, pricePerNight, numberOfBeds, size, hotelName);
                            rooms.Add(room);
                        }
                    }
                }
            }
            return rooms;
        }

        public Room GetRoom(int hotelID, int roomID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT r.*, h.Name AS HotelName FROM Room r INNER JOIN Hotel h ON r.HotelID = h.HotelID WHERE r.HotelID = @HotelID AND r.RoomID = @RoomID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HotelID", hotelID);
                    command.Parameters.AddWithValue("@RoomID", roomID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int number = (int)reader["Number"];
                            string roomType = (string)reader["RoomType"];
                            string description = (string)reader["Description"];
                            decimal pricePerNight = (decimal)reader["PricePerNight"];
                            int numberOfBeds = (int)reader["NumberOfBeds"];
                            double size = Convert.ToDouble(reader["Size"]);
                            string hotelName = (string)reader["HotelName"];

                            Room room = new Room(roomID, number, roomType, description, pricePerNight, numberOfBeds, size, hotelName);
                            return room;
                        }
                    }
                }
            }
            return null;
        }
    }
}
