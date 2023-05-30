using FinalPoject.HomeUCI.PanelButtonUser;
using FinalPoject.HomeUCI;
using FinalPoject.Cars;
//using FinalPoject.Cars.CarElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace FinalPoject.Cars
{
    public partial class SearchCar : UserControl
    {
        private static SearchCar _obj;
        public static SearchCar Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new SearchCar();
                return _obj;
            }
        }
        public SearchCar()
        {
            InitializeComponent();
            populateComboBox();
        }
        


        private void populateComboBox()
        {
            if (ClassCombo.Items.Count == 0)
            {
                ClassCombo.Items.Add("Family");
                ClassCombo.Items.Add("Business & Family");
                ClassCombo.Items.Add("Premium");
            }

            if (BrandCombo.Items.Count == 0)
            {
                BrandCombo.Items.Add("Audi");
                BrandCombo.Items.Add("BMW");
                BrandCombo.Items.Add("Dacia");
                BrandCombo.Items.Add("Ford");
                BrandCombo.Items.Add("Seat");
                BrandCombo.Items.Add("Mercedes - Benz");
                BrandCombo.Items.Add("Skoda");
                BrandCombo.Items.Add("Volkswagen");
                BrandCombo.Items.Add("Cupra");
            }

            if (GearboxCombo.Items.Count == 0)
            {
                GearboxCombo.Items.Add("Manual");
                GearboxCombo.Items.Add("Automatic");
            }

            if (TransmissionCombo.Items.Count == 0)
            {
                TransmissionCombo.Items.Add("Rear");
                TransmissionCombo.Items.Add("Integral (4x4)");
            }

            if (FuelCombo.Items.Count == 0)
            {
                FuelCombo.Items.Add("Gasoline");
                FuelCombo.Items.Add("Diesel");
                FuelCombo.Items.Add("Hybrid");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //DataAccessCar data = new DataAccessCar(); 
            //DateTime dateTakeover = DateTakeover.Value;
            //DateTime dateDelivery = DateDelivery.Value;

            //int numberOfDays = CalculateNumberOfDays(dateTakeover, dateDelivery);


            //if (ClassCombo.SelectedItem == null && BrandCombo.SelectedItem == null && GearboxCombo.SelectedItem == null &&
            //    TransmissionCombo.SelectedItem == null && FuelCombo.SelectedItem == null && string.IsNullOrEmpty(PickupLocation.Text) &&
            //    string.IsNullOrEmpty(DeliveryLocation.Text) && IsDateSelectionValid())
            //{
            //    MessageBox.Show("Please select valid data.", "Invalid Data Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //if (IsDateSelectionValid()&& ClassCombo.SelectedItem != null && BrandCombo.SelectedItem != null && GearboxCombo.SelectedItem != null &&
            //      TransmissionCombo.SelectedItem != null && FuelCombo.SelectedItem != null && PickupLocation.Text != "" &&
            //        DeliveryLocation.Text != "")
            //{
            //    List<Car> carList = FindCars(data.GetCars(), ClassCombo.SelectedItem.ToString(), BrandCombo.SelectedItem.ToString(),
            //        GearboxCombo.SelectedItem.ToString(), TransmissionCombo.SelectedItem.ToString(), FuelCombo.SelectedItem.ToString(),
            //        PickupLocation.Text, DeliveryLocation.Text);


            //    MainMenu.Instance.mainPanel.Controls.Clear();
            //    HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            //    HomeSignedIn.Instance.Dock = DockStyle.Fill;
            //    MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
            //    HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
            //    ButtonUser.Instance.BringToFront();
            //    ButtonUser.Instance.Location = new Point(654, 6);
            //    foreach (Car car in carList)
            //    {
            //        CarElement carElement = new CarElement(car);
            //        carElement.Dock = DockStyle.Top;
            //        HomeSignedIn.Instance.pnlAccount.Controls.Add(carElement);

            //      SearchCar.Instance.BringToFront();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select valid check-in and check-out dates.", "Invalid Date Selection",
            //       MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            DataAccessCar data = new DataAccessCar();
            DateTime dateTakeover = DateTakeover.Value;
            DateTime dateDelivery = DateDelivery.Value;

            int numberOfDays = CalculateNumberOfDays(dateTakeover, dateDelivery);

            // Verifică dacă nu s-a selectat o clasă, marcă, cutie de viteze, transmisie, tip de combustibil și locație de preluare/livrare
            if (ClassCombo.SelectedItem == null || BrandCombo.SelectedItem == null || GearboxCombo.SelectedItem == null ||
                TransmissionCombo.SelectedItem == null || FuelCombo.SelectedItem == null || string.IsNullOrEmpty(PickupLocation.Text) ||
                string.IsNullOrEmpty(DeliveryLocation.Text))
            {
                MessageBox.Show("Please complete all fields.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Întrerupe execuția metodei pentru a nu continua în caz de eroare
            }

            // Verifică dacă datele de check-in și check-out sunt valide
            if (!IsDateSelectionValid())
            {
                MessageBox.Show("Please select valid check-in and check-out dates.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Întrerupe execuția metodei pentru a nu continua în caz de eroare
            }

            // Obține lista de mașini filtrată
            List<Car> carList = FindCars(data.GetCars(), ClassCombo.SelectedItem.ToString(), BrandCombo.SelectedItem.ToString(),
                GearboxCombo.SelectedItem.ToString(), TransmissionCombo.SelectedItem.ToString(), FuelCombo.SelectedItem.ToString(),
                PickupLocation.Text, DeliveryLocation.Text);

            // Verifică dacă nu există mașini disponibile
            //if (carList.Count == 0)
            //{
            //    MessageBox.Show("No cars available with the selected criteria.", "No Cars Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return; // Întrerupe execuția metodei pentru a nu continua în caz de eroare
            //}

            // Eliberează panourile și adaugă panourile necesare
            MainMenu.Instance.mainPanel.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            HomeSignedIn.Instance.Dock = DockStyle.Fill;
            MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
            HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.BringToFront();
            ButtonUser.Instance.Location = new Point(654, 6);

            // Adaugă CarElement pentru fiecare mașină în lista filtrată
            foreach (Car car in carList)
            {
                CarElement carElement = new CarElement(car);
                carElement.Dock = DockStyle.Top;
                HomeSignedIn.Instance.pnlAccount.Controls.Add(carElement);
            }

            // Mesaj de succes sau alte acțiuni dorite
            MessageBox.Show("Search completed successfully!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarElement selectedCarElement = new CarElement();

            // Adaugă CarElement în panoul corespunzător
            selectedCarElement.Dock = DockStyle.Top;
            HomeSignedIn.Instance.pnlAccount.Controls.Add(selectedCarElement);


        }

        private List<Car> FindCars(List<Car> list, string clas, string brand, string gearbox, string transmission, string fuelTipe,
            string pichupLocation, string deliveryLocation)
        {
            
            List<Car> filteredCars = list.Where(h => h.Class == clas && h.Brand == brand && h.Gearbox == gearbox && h.Transmission == transmission &&
            h.FuelTipe == fuelTipe && h.PickupLocation == pichupLocation && h.DeliveryLocation == deliveryLocation).ToList();
            return filteredCars;
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
                MessageBox.Show("Please select valid check-in and check-out dates.", "Invalid Date Selection",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool IsDateSelectionValid()
        {
            // Verifică dacă ambele date de check-in și check-out sunt selectate și valide
            DateTime checkInDate = DateTakeover.Value;
            DateTime checkOutDate = DateDelivery.Value;

            // Verifică dacă ambele date sunt diferite de valoarea implicită
            if (checkInDate != DateTime.MinValue && checkOutDate != DateTime.MinValue)
            {
                // Verifică dacă data de check-out este ulterioară datei de check-in
                if (checkOutDate > checkInDate)
                {
                    return true; // Selecția datelor este validă
                }
            }

            return false; // Selecția datelor este invalidă
        }

    }
}
