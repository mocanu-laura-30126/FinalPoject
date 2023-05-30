using FinalPoject.HomeUCI;
using FinalPoject.HomeUCI.PanelButtonUser;
using FinalPoject.Hotels.HotelElement.HotelRooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalPoject.Hotels
{
    public partial class SearchHotel : UserControl
    {
        private static SearchHotel _obj;
        public static SearchHotel Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new SearchHotel();
                return _obj;
            }
        }
        public SearchHotel()
        {
            InitializeComponent();
            populateComboBox();


        }
        private void populateComboBox()
        {
            CmBoxDestination.Items.Add("Algavre");
            CmBoxDestination.Items.Add("Dubrovnik");
            CmBoxDestination.Items.Add("Santorini");
            CmBoxDestination.Items.Add("Madrid");
            CmBoxDestination.Items.Add("Roma");
        }

        private void SearchHotel_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataAccess data=new DataAccess();
            DateTime startDate = DTPCheckIn.Value;
            DateTime endDate = DTPCheckOut.Value;

            int numberOfDays = CalculateNumberOfDays(startDate, endDate);

            if (CmBoxDestination.SelectedItem != null && TextBoxNrRooms.Text != "" && numberOfDays>0)
            {
                List<Hotel> hotelList = FindHotels(data.GetHotels(), CmBoxDestination.SelectedItem.ToString(), Convert.ToInt32(TextBoxNrRooms.Text));
                MainMenu.Instance.mainPanel.Controls.Clear();
                HomeSignedIn.Instance.pnlAccount.Controls.Clear();
                HomeSignedIn.Instance.Dock = DockStyle.Fill;
                MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
                HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
                ButtonUser.Instance.BringToFront();
                ButtonUser.Instance.Location = new Point(654, 6);
                foreach (Hotel hotel in hotelList)
                {
                    HotelElement.HotelElement hotelElement = new HotelElement.HotelElement(hotel, numberOfDays);
                    hotelElement.Dock = DockStyle.Top;
                    HomeSignedIn.Instance.pnlAccount.Controls.Add(hotelElement);
                    HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
                    ButtonUser.Instance.Location = new Point(654, 6);
                    ButtonUser.Instance.BringToFront();
                }
            }
        }

        private List<Hotel> FindHotels(List<Hotel> list,String Destination,int NrOfRooms)
        {
            int filteringRating = getSelectedRating();
            List<Hotel> filteredHotels = list.Where(h => h.City == Destination && h.NumberOfRooms >= NrOfRooms &&  h.Rating >= filteringRating)
                                         .ToList();
            return filteredHotels;
        }

        private int CalculateNumberOfDays(DateTime startDate, DateTime endDate)
        {
            if (startDate <= endDate)
            {
                TimeSpan difference = endDate.Subtract(startDate);
                return (int)difference.TotalDays;
            }
            else
            {
                return -1;
            }
        }


        private int getSelectedRating()
        {
            if (RdBtn2Star.Checked)
            {
                return 2;
            }
            else if (RdBtn3Star.Checked)
            {
                return 3;
            }
            else if (RdBtn4Star.Checked)
            {
                return 4;
            }
            else if (RdBtn5Star.Checked)
            {
                return 5;
            }
            else 
                return 1;
        }
        public DateTime getCheckIn()
        {
            return DTPCheckIn.Value.Date;
        }

        public DateTime getCheckOut()
        {
            return DTPCheckOut.Value.Date;
        }
    }
}
