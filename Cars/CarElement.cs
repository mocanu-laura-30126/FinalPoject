using FinalPoject.HomeUCI;
using FinalPoject.Hotels.HotelElement.HotelRooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.Cars
{
    public partial class CarElement : UserControl
    {
        private Car car;
        public CarElement()
        {
            InitializeComponent();
        }

        public CarElement(Car car)
        {
            InitializeComponent();
            this.car = car;
            CarImg.Image = car.Images[0];
            CarName.Text = car.Brand + " " + car.Model;
            CarSeats.Text = car.NumSeats.ToString();
            CarDoors.Text = car.NumDoors.ToString();
            CarBags.Text = car.NumBags.ToString();

            TimeSpan difference = car.DateOfDelivery.Subtract(car.DateOfTakeover);
            int differenceInDays = (int)difference.TotalDays;

            CarPrice.Text = (car.PricePerDay * differenceInDays).ToString();
            int maxLength = 70;

            if (CarName.Text.Length > maxLength)
            {
                string truncatedName = CarName.Text.Substring(0, maxLength) + "...";
                CarName.Text = truncatedName;
            }
            else
            {
                CarName.Text = CarName.Text;
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This car was selected!");
            //CarPage carPage = new CarPage();
            //HomeSignedIn.Instance.pnlAccount.Controls.Add(carPage);
            //carPage.BringToFront();
        }
    }
}
