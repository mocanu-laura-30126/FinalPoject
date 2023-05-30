
using FinalPoject;
using FinalPoject.Hotels;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FinalPoject.FlightsUC
{
    public partial class Flights : UserControl
    { 
        private static Flights _obj;

        public static Flights Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Flights();
                return _obj;
            }
        }

        public Panel pnlFlightContent
        {
            get { return PnlFlightContent; }
            set { PnlFlightContent = value; }
        }
        public Flights()
        {
            InitializeComponent();
            Login.myCon = new SqlConnection("Data Source=DESKTOP-4RB4PAI\\SQLEXPRESS;Initial Catalog=TripWise;Integrated Security=True");
            Login.myCon.Open();
            LoadFlightsData();
        }

        public void Flights_Load(object sender, EventArgs e)
        {
            //LoadFlightsData();
        }

        public void LoadFlightsData()
        {
            
            string selectedOrigin = guna2ComboBoxOrigin.SelectedItem?.ToString();
            string selectedDestination = guna2ComboBoxDest.SelectedItem?.ToString();

            string query = "SELECT Origin, Destination, DepartureTimeFromOrigin, DepartureTimeFromDestination, ArrivalTimeToDest, ArrivalTimeToOrigin FROM Flights";

            SqlCommand command = new SqlCommand(query, Login.myCon);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string origin = reader.GetString(0);
                string destination = reader.GetString(1);
                string departureTimeFromOrigin = reader.GetString(2);
                string departureTimeFromDestination = reader.GetString(3);
                string arrivalToDestination = reader.GetString(4);
                string arrivalToOrigin = reader.GetString(5);

                if ((string.IsNullOrEmpty(selectedOrigin) || origin == selectedOrigin) &&
                    (string.IsNullOrEmpty(selectedDestination) || destination == selectedDestination))
                {
                    guna2ComboBoxOrigin.Items.Add(origin);
                    guna2ComboBoxDest.Items.Add(destination);

                    if (destination == selectedDestination)
                    {
                        guna2ComboBoxDepartureTimeFromOrig.Items.Add(departureTimeFromOrigin);
                        guna2ComboBoxArrivalTimeToDest.Items.Add(arrivalToDestination);
                    }
                    if (origin == selectedOrigin)
                    {
                        guna2ComboBoxDepartureTimeFromDest.Items.Add(departureTimeFromDestination);
                        ComboBoxArrivalTimeToOrig.Items.Add(arrivalToOrigin);
                    }
                }
            }
            reader.Close();
            Login.myCon.Close();
        }

        public decimal CalculateTicketPrice(int numPersons, string destination, string baggageOption)
        {
            Login.myCon.Open();
            decimal totalPrice = 0.0m;

            string query = "SELECT Price FROM Flights WHERE Destination = @Destination";
            SqlCommand command = new SqlCommand(query, Login.myCon);
            command.Parameters.AddWithValue("@Destination", destination);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                decimal basePrice = reader.GetDecimal(0); decimal baggageFee = 0.0m;
                totalPrice = basePrice * numPersons;
                if (baggageOption == "Free carry-on bag")
                {
                    baggageFee = 0.0m;
                    totalPrice += baggageFee;
                }
                else if (baggageOption == "Free carry-on bag and Trolley bag")
                {
                    baggageFee = 50.0m;
                    totalPrice += baggageFee;
                }
                else if (baggageOption == "32kg checked-in bag")
                {
                    baggageFee = 250.0m;
                    totalPrice += baggageFee;
                }
            }

            reader.Close();
            Login.myCon.Close();
            return totalPrice;
        }

        public bool IsDateSelectionValid()
        {
            DateTime checkInDate = guna2DateTimePicker1.Value;
            DateTime checkOutDate = guna2DateTimePicker2.Value;
            if (checkInDate != DateTime.MinValue && checkOutDate != DateTime.MinValue)
            {
                if (checkOutDate > checkInDate)
                {
                    return true;
                }
            }

            return false;
        }
        public DateTime GetSelectedDateTime()
        {
            return guna2DateTimePicker1.Value;
        }
        public DateTime GetSelectedDateTime2()
        {
            return guna2DateTimePicker2.Value;
        }

        private void SelectFlightButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBoxPassengers.Text))
            {
                MessageBox.Show("Please enter the number of passengers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numberPers = int.Parse(guna2TextBoxPassengers.Text);
            string destination = guna2ComboBoxDest.SelectedItem.ToString();

            if (IsDateSelectionValid())
            {
                string baggageOption = "";
                if (guna2RadioButton1Free.Checked)
                {
                    baggageOption = "Free carry-on bag";
                }
                else if (guna2RadioButtonFreeAndTrolley.Checked)
                {
                    baggageOption = "Free carry-on bag and Trolley bag";
                }
                else if (guna2RadioButton32.Checked)
                {
                    baggageOption = "32kg checked-in bag";
                }

                decimal ticketPrice = CalculateTicketPrice(numberPers, destination, baggageOption);
                textBoxPrice.Text = ticketPrice.ToString("0.00");
                if (MainMenu.User != null)
                {
                    try
                    {
                        string insertQuery = "INSERT INTO UserFlightReservation (UserID, FlightID, DepartureDate, ReturnDate) VALUES (@UserID, @FlightID, @DepartureDate, @ReturnDate)";
                        SqlCommand command = new SqlCommand(insertQuery, Login.myCon);
                        command.Parameters.AddWithValue("@UserID", MainMenu.User.UserID);
                        command.Parameters.AddWithValue("@FlightID", GetFlightIDByDestination(Convert.ToString(guna2ComboBoxDest.SelectedItem)));
                        command.Parameters.AddWithValue("@DepartureDate", guna2DateTimePicker1.Value.Date); 
                        command.Parameters.AddWithValue("@ReturnDate", guna2DateTimePicker1.Value.Date);

                        Login.myCon.Open();
                        command.ExecuteNonQuery();
                        Login.myCon.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select valid check-in and check-out dates.", "Invalid Date Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int GetFlightIDByDestination(string destination)
        {
            int flightID = -1;

            try
            {
                string selectQuery = "SELECT FlightID FROM Flights WHERE Destination = @Destination";
                SqlCommand command = new SqlCommand(selectQuery, Login.myCon);
                command.Parameters.AddWithValue("@Destination", destination);

                Login.myCon.Open();
                object result = command.ExecuteScalar();
                Login.myCon.Close();

                if (result != null && result != DBNull.Value)
                {
                    flightID = (int)result;
                }
            }
            catch (Exception ex)
            {
            }

            return flightID;
        }


        private void guna2ComboBoxOrigin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Login.myCon.Open();
            String selectedOrigin = guna2ComboBoxOrigin.SelectedItem.ToString();
            guna2ComboBoxDest.Items.Clear(); 

            string query = "SELECT Destination FROM Flights WHERE Origin = @Origin";

            SqlCommand command = new SqlCommand(query, Login.myCon);
            command.Parameters.AddWithValue("@Origin", selectedOrigin);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string destination = reader.GetString(0);
                guna2ComboBoxDest.Items.Add(destination);
            }

            reader.Close();
        }

        private void guna2ComboBoxDest_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            LoadFlightsData();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }

}




