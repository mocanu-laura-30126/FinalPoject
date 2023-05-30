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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
    using System.Reflection;

    public class DataAccessCar
    {
        private string connectionString = "Data Source=DESKTOP-4RB4PAI\\SQLEXPRESS;Initial Catalog=TripWise;Integrated Security=True"; // înlocuiește "YourConnectionString";

        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int carID = (int)reader["CarID"];
                            string clas = (string)reader["Class"];
                            string brand = (string)reader["Brand"];
                            string fuelTipe = (string)reader["FuelTipe"];
                            string transmission = (string)reader["Transmission"];
                            string gearbox = (string)reader["Gearbox"];
                            string pickupLocation = (string)reader["PickupLocation"];
                            DateTime dateOfTakeover = (DateTime)reader["DateOfTakeover"];
                            string deliveryLocation = (string)reader["DeliveryLocation"];
                            DateTime dateOfDelivery = (DateTime)reader["DateOfDelivery"];
                            int num_seats = (int)reader["NumSeats"];
                            int num_doors = (int)reader["NumDoors"];
                            int num_bags = (int)reader["NumBags"];
                            int pricePerDay = (int)reader["PricePerDay"];
                            // bool isAvaible = (bool)reader["IsAvaible"];
                             string model = (string)reader["Model"];
                            //int productionYear = (int)reader["ProductionYear"];

                            Car car = new Car(carID, clas, brand, fuelTipe, transmission, gearbox, pickupLocation, dateOfTakeover, deliveryLocation, dateOfDelivery, num_seats, num_doors, num_bags, pricePerDay,model);
                            cars.Add(car);
                        }
                    }
                }
            }

            return cars;
        }
    }

}
