using FinalPoject.HomeUCI;
using FinalPoject.HomeUCI.Account;
using FinalPoject.HomeUCI.Account.Personal_Details;
using FinalPoject.HomeUCI.PanelButtonUser;
using FinalPoject.Hotels;
using FinalPoject.Hotels.HotelElement;
using FinalPoject.Hotels.HotelElement.HotelRooms;
using FinalPoject.Cars;
using FinalPoject.FlightsUC;
//using FinalPoject.Cars.CarElement;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using FinalPoject.DestinationUCI;

namespace FinalPoject
{
    public partial class MainMenu : Form
    {
        public Currency currency= new Currency("US Dollar", "USD", 1.0m);
        private static User user;
        private static MainMenu _obj;
        public  DataAccess acces;

        public static  User User { 
            get { return user; } 
            set { user = value; }
        }

        public static MainMenu Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new MainMenu();
                return _obj;
            }
        }

        public Panel mainPanel
        {
            get { return MainPanel; }
            set { MainPanel = value; }
        }
        public MainMenu()
        {
            InitializeComponent();
            acces = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            HomeUc UC = new HomeUc();
            UC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(UC);
        }

        private void moveImageBox(object sender)
        {
            Guna2Button button= (Guna2Button)sender;
            ImgSlider.Location=new Point(button.Location.X+116, button.Location.Y-28);
            ImgSlider.SendToBack();
        }
        public void Btn_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Instance.mainPanel.Controls.Clear();
            if (Login.IsLoggedIn)
            {
                MainMenu.Instance.mainPanel.Controls.Clear();
                HomeSignedIn.Instance.Dock = DockStyle.Fill;
                MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
                HomeSignedIn.Instance.pnlAccount.Controls.Clear();
                HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
                ButtonUser.Instance.Location = new Point(654, 6);
                HomeSignedIn.Instance.BringToFront();
            }
            else
            {
                HomeUc.Instance.Dock = DockStyle.Fill;
                Instance.mainPanel.Controls.Add(HomeUc.Instance);
                HomeUc.Instance.BringToFront();
            }
        }

        private void BtnAccomodations_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            HomeSignedIn.Instance.Dock = DockStyle.Fill;
            Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
            SearchHotel.Instance.Dock= DockStyle.Fill;
            HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location = new Point(654, 6);
            HomeSignedIn.Instance.pnlAccount.Controls.Add(SearchHotel.Instance);
            HomeSignedIn.Instance.BringToFront();
        }

        private void BtnFlights_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            HomeSignedIn.Instance.Dock = DockStyle.Fill;
            MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
            SearchHotel.Instance.Dock = DockStyle.Fill;
            Flights.Instance.Dock = DockStyle.Fill;
            HomeSignedIn.Instance.pnlAccount.Controls.Add(Flights.Instance);
            Flights.Instance.pnlFlightContent.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location = new Point(654, 6);
            ButtonUser.Instance.BringToFront();
        }

        private void BtnTrains_Click(object sender, EventArgs e)
        {
            //this.mainPanel.Controls.Clear();
            //HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            //HomeSignedIn.Instance.Dock = DockStyle.Fill;
            //Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
            //HomeSignedIn.Instance.pnlAccount.Controls.Add(new HotelElement());
        }

        private void BtnCars_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            HomeSignedIn.Instance.Dock = DockStyle.Fill;
            MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
            HomeSignedIn.Instance.pnlAccount.Controls.Add(SearchCar.Instance);
            SearchCar.Instance.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location = new Point(654, 6);
            ButtonUser.Instance.BringToFront();
        }

        private void BtnDestinations_Click(object sender, EventArgs e)
        {
            Destinations userControl = new Destinations();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
        }
    }
}
