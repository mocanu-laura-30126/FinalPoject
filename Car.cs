using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Reflection;

namespace FinalPoject
{
    public class Car
    {
        public int CarID { get; set; }
        public string Class { get; set; }
        public string Brand { get; set; }
        public string FuelTipe { get; set; }
        public string Transmission { get; set; }
        public string Gearbox { get; set; }
        public string PickupLocation { get; set; }
        public DateTime DateOfTakeover { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public int NumSeats { get; set; }
        public int NumDoors { get; set; }
        public int NumBags { get; set; }
        public decimal PricePerDay { get; set; }
      //  public bool IsAvaible { get; set; }
       public string Model { get; set; }
      //  public int ProductionYear { get; set; }
        public List<System.Drawing.Image> Images { get; set; }

        public Car(int carID, string clas, string brand, string fuelTipe, string transmission, string gearbox, string pickupLocation,
            DateTime dateOfTakeover, string deliveryLocation, DateTime dateOfDelivery, int numSeats, int numDoors, int numBags, 
            decimal pricePerDay,string model )
        {
            CarID = carID;
            Class = clas;
            Brand = brand;
            FuelTipe = fuelTipe;
            Transmission = transmission;
            Gearbox = gearbox;
            PickupLocation = pickupLocation;
            DateOfTakeover = dateOfTakeover;
            DeliveryLocation = deliveryLocation;
            DateOfDelivery = dateOfDelivery;
            NumSeats = numSeats;
            NumDoors = numDoors;
            NumBags = numBags;
            PricePerDay = pricePerDay;
           // IsAvaible = isAvaible;
            Model = model;
          //  ProductionYear = productionYear;
        }

        //private List<System.Drawing.Image> LoadCarImages(string carName)
        //{
        //    List<System.Drawing.Image> images = new List<System.Drawing.Image>();

        //    string carFolderPath = "E:\\AUTOMATICA\\II\\PROIECT\\Proiect_II\\Proiect_II\\FinalPoject_2_David\\Images\\CarImages";

        //    string searchPattern = $"car_{carName}*.jpg";

        //    string carImg = carFolderPath + "\\" + Brand+Model + "\\";
        //    string[] imageFiles = Directory.GetFiles(Path.Combine(carFolderPath, carName), searchPattern);

        //    foreach (string filePath in imageFiles)
        //    {
        //        System.Drawing.Image image = System.Drawing.Image.FromFile(filePath);
        //        images.Add(image);
        //    }

        //    return images;
        //}
    }
}
