using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.IO;

namespace FinalPoject
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Name { get; set;}
        public string Description { get; set;}
        public string Address { get; set;}
        public string City { get; set;}
        public int NumberOfRooms { get; set;}
        public int Rating { get; set;}
        public List<Room> Rooms { get; set;}
        public List<System.Drawing.Image> Images { get;set;}
        public Hotel(int hotelID, string name, string description, string address, string city, int numberOfRooms, int rating, List<Room> rooms)
        {
            HotelID = hotelID;
            Name = name;
            Description = description;
            Address = address;
            City = city;
            NumberOfRooms = numberOfRooms;
            Rating = rating;
            Rooms = rooms;
            Images = LoadHotelImages(name.Split(' ')[0]);
        }
        public Room GetRoomWithLowestPrice()
        {
            decimal roomWithLowestPrice = Rooms.Min(room => room.PricePerNight);
            return Rooms.FirstOrDefault(room => room.PricePerNight == roomWithLowestPrice);
        }



        private List<System.Drawing.Image> LoadHotelImages(string hotelName)
        {
            List<System.Drawing.Image> images = new List<System.Drawing.Image>();

            string hotelFolderPath = "C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\Images\\HotelImages";

            string searchPattern = $"hotel_{hotelName}*.jpg";

            string HotelImg = hotelFolderPath + "\\" + Name + "\\";
            string[] imageFiles = Directory.GetFiles(Path.Combine(hotelFolderPath, hotelName), searchPattern);

            foreach (string filePath in imageFiles)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(filePath);
                images.Add(image);
            }

            return images;
        }
    }
}
