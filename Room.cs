using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FinalPoject
{
    public class Room
    {
        public int RoomID {  get; set; }
        public int Number { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
        public Decimal PricePerNight { get; set; }
        public int NumberOfBeds { get; set; }
        public double Size { get; set; }
        public String BedSize { get; set; }
        public List<System.Drawing.Image> RoomImages { get; set; }
        public Currency SelectedCurrency { get; set; }
        public Room(int roomID, int number, string rooomType, string description, decimal pricePerNight, int numberOfBeds, double size,string hotelName)
        {
            RoomID = roomID;
            Number = number;
            RoomType = rooomType;
            Description = description;
            NumberOfBeds = numberOfBeds;
            Size = size;
            BedSize = number == 2 ? "Single" : "Double";
            SelectedCurrency = new Currency("US Dollar", "USD", 1.0m);
            PricePerNight = Currency.ConvertToCurrency(pricePerNight, SelectedCurrency);
            RoomImages = LoadRoomImages(hotelName.Split(' ')[0], number);
        }


        private List<System.Drawing.Image> LoadRoomImages(string hotelName, int roomNumber)
        {
            List<System.Drawing.Image> images = new List<System.Drawing.Image>();

            string hotelFolderPath = "C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\Images\\HotelImages";
            string roomFolderPath = Path.Combine(hotelFolderPath, hotelName, $"room_{roomNumber}");

            string[] imageFiles = Directory.GetFiles(roomFolderPath, "*.jpg");


            foreach (string filePath in imageFiles)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(filePath);
                images.Add(image);
            }

            return images;
        }

        public void UpdatePrice(Currency targetCurrency)
        {

            if (targetCurrency != null && targetCurrency != this.SelectedCurrency)
            {
                this.PricePerNight = Currency.ConvertToCurrency(this.PricePerNight, targetCurrency);
                this.SelectedCurrency = targetCurrency;
            }
        }


    }
}
