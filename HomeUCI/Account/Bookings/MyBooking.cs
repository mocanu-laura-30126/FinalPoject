using FinalPoject.HomeUCI.Account.Bookings.FlightBooking;
using FinalPoject.HomeUCI.Account.Bookings.RoomBooking;
using FinalPoject.HomeUCI.PanelButtonUser;
using Guna.UI2.WinForms;
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

namespace FinalPoject.HomeUCI.Account.Bookings
{
    public partial class MyBooking : UserControl
    {
        private static MyBooking _obj;
        private static DataTable _dataTable = new DataTable();
        public static MyBooking Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new MyBooking();
                return _obj;
            }
        }
        public MyBooking()
        {
            InitializeComponent();
        }

        public Panel pnlMainInfo
        {
            get { return PnlMainInfo; }
            set { PnlMainInfo = value; }
        }
        public DataTable GetReservationsByUserID(int userID)
        {
            DataTable reservationsTable = new DataTable();

            string selectQuery = @"SELECT 
                        H.HotelID,
                        R.RoomID,
                        H.Name AS HotelName,
                        RR.Cost AS TotalCost,
                        RR.CurrencyCode,
                        RR.CheckIn,
                        RR.CheckOut
                   FROM 
                        RoomReservation RR
                        INNER JOIN Room R ON RR.RoomID = R.RoomID
                        INNER JOIN Hotel H ON R.HotelID = H.HotelID
                   WHERE 
                        RR.UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(Login.myCon.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(reservationsTable);
                }
            }
            return reservationsTable;
        }

        public DataTable GetReservationFlightsByUserID(int userID)
        {
            DataTable reservationsTable = new DataTable();

            string selectQuery = @"
        SELECT
            U.FirstName + ' ' + U.LastName AS FullName,
            F.Origin,
            F.Destination,
            CONCAT(F.Price, ' USD') AS Price,
            R.DepartureDate,
            R.ReturnDate
        FROM
            UserFlightReservation R
            INNER JOIN [User] U ON R.UserID = U.UserID
            INNER JOIN Flights F ON R.FlightID = F.FlightID
        WHERE
            R.UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(Login.myCon.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(reservationsTable);
                }
            }

            return reservationsTable;
        }


        private void BtnHotelRoom_Click(object sender, EventArgs e)
        {
            refreshPanel();
            if (MainMenu.User != null)
            {
                _dataTable = GetReservationsByUserID(MainMenu.User.UserID);
                DataAccess dataAccess = new DataAccess();
                foreach (DataRow row in _dataTable.Rows)
                {
                    Room room = dataAccess.GetRoom((int)row["HotelID"], (int)row["RoomID"]);
                    RoomBookingElement roomBookingElement = new RoomBookingElement((string)row["HotelName"], room, (decimal)row["TotalCost"], (string)row["CurrencyCode"],
                        (DateTime)row["CheckIn"], (DateTime)row["CheckOut"]);

                    bool elementExists = CheckIfElementExists(roomBookingElement);

                    if (!elementExists)
                    {
                        this.PnlMainInfo.Controls.Add(roomBookingElement);
                        roomBookingElement.Dock = DockStyle.Top;
                    }
                }
            }
        }

        private void refreshPanel()
        {
            Instance.pnlMainInfo.Controls.Clear();
            Instance.pnlMainInfo.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location = new Point(446, 11);
            ButtonUser.Instance.Height = 0;
            ButtonUser.Instance.BringToFront();
        }

        private bool CheckIfElementExists(RoomBookingElement newElement)
        {
            foreach (Control control in this.PnlMainInfo.Controls)
            {
                if (control is RoomBookingElement existingElement)
                {
 
                    if (AreElementsEqual(existingElement, newElement))
                    {
                        return true; 
                    }
                }
            }
            return false; 
        }

        public bool AreElementsEqual(RoomBookingElement element1, RoomBookingElement element2)
        {
            return element1.txtBHotelName.Text == element2.txtBHotelName.Text &&
                   element1.txtBRoomNumber.Text == element2.txtBRoomNumber.Text;
        }

        private bool CheckIfElementFlightExists(FlightTicket newElement)
        {
            foreach (Control control in this.Controls)
            {
                if (control is FlightTicket existingElement)
                {
                    if (AreElementsFlightEqual(existingElement, newElement))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AreElementsFlightEqual(FlightTicket element1, FlightTicket element2)
        {
            return element1.txtBoxPassengerName.Text == element2.txtBoxPassengerName.Text &&
                   element1.txtBoxOrigin.Text == element2.txtBoxOrigin.Text;
        }



        private void BtnCarsRented_Click(object sender, EventArgs e)
        {
        }

        private void BtnTrainTicket_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnPlaneTicket_Click(object sender, EventArgs e)
        {
            refreshPanel();
            if (MainMenu.User != null)
            {
                _dataTable = GetReservationFlightsByUserID(MainMenu.User.UserID);
                foreach (DataRow row in _dataTable.Rows)
                {
                    FlightTicket flightTicket = new FlightTicket((string)row["FullName"], (string)row["Origin"],
                        (string)row["Destination"], (DateTime)row["DepartureDate"], (DateTime)row["ReturnDate"], (string)row["Origin"]);
                    bool elementExists = CheckIfElementFlightExists(flightTicket);
                    if (!elementExists)
                    {
                        this.PnlMainInfo.Controls.Add(flightTicket);
                        flightTicket.Dock = DockStyle.Top;
                    }
                }
            }
        }

        private void BtnCarsRented_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BtnCarsRented.Checked)
            {
                this.BtnCarsRented.Font = new Font(BtnCarsRented.Font, FontStyle.Underline);
                this.BtnCarsRented.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnCarsRented.Font = new Font(BtnCarsRented.Font, FontStyle.Regular);
                this.BtnCarsRented.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }

        private void BtnTrainTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BtnTrainTicket.Checked)
            {
                this.BtnTrainTicket.Font = new Font(BtnTrainTicket.Font, FontStyle.Underline);
                this.BtnTrainTicket.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnTrainTicket.Font = new Font(BtnTrainTicket.Font, FontStyle.Regular);
                this.BtnTrainTicket.ForeColor = Color.FromArgb(26, 26, 26);
            }

        }

        private void BtnPlaneTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BtnPlaneTicket.Checked)
            {
                this.BtnPlaneTicket.Font = new Font(BtnPlaneTicket.Font, FontStyle.Underline);
                this.BtnPlaneTicket.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnPlaneTicket.Font = new Font(BtnPlaneTicket.Font, FontStyle.Regular);
                this.BtnPlaneTicket.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }

        private void BtnHotelRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BtnHotelRoom.Checked)
            {
                this.BtnHotelRoom.Font = new Font(BtnHotelRoom.Font, FontStyle.Underline);
                this.BtnHotelRoom.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnHotelRoom.Font = new Font(BtnHotelRoom.Font, FontStyle.Regular);
                this.BtnHotelRoom.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }
    }
}
