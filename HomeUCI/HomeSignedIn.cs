using FinalPoject.HomeUCI.Account;
using FinalPoject.HomeUCI.Account.Personal_Details;
using FinalPoject.HomeUCI.Account.Preferences;
using FinalPoject.HomeUCI.Account.Security;
using FinalPoject.HomeUCI.PanelButtonUser;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalPoject.HomeUCI
{
    public partial class HomeSignedIn : UserControl
    {
        private static HomeSignedIn _obj;
        private static List<Currency> currencies;
        private List<Panel> panelsToUpdate;
        public static HomeSignedIn Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new HomeSignedIn();
                return _obj;
            }
        }
        public List<Currency> GetCurrencies()
        {
            return currencies;
        }

        public Guna2ComboBox cmbCurrency
        {
            get { return CmbBoxCurrency; }
            set { CmbBoxCurrency = value; }
        }
        public Panel pnlAccount
        {
            get { return PnlAccount; }
            set { PnlAccount = value; }
        }
        public Guna2Button btnDropDown
        {
            get { return BtnDropDown; }
            set { BtnDropDown = value; }
        }   
        public HomeSignedIn()
        {
            InitializeComponent();
            PopulateComboBox(CmbBoxCurrency,false);
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
   
        }

        private void BtnDropDown_Click(object sender, EventArgs e)
        {
            int targetHeight = 193;
            int newHeight = 0;
            if (ButtonUser.Instance.Height == targetHeight)
            {
                newHeight = 0;
            }
            else
            {
                newHeight = targetHeight;
            }
            ButtonUser.Instance.Height = newHeight;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeSignedIn_Load(object sender, EventArgs e)
        {
            ButtonUser.Instance.Height = 0;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnCart_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplayUN_Click(object sender, EventArgs e)
        {

        }

        private void PnlAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbBoxCurrency.SelectedItem != null)
            {
                MainMenu.Instance.currency=this.GetCurrencies().Find(c => c.Code == CmbBoxCurrency.SelectedItem.ToString());
                foreach (Hotel hotel in MainMenu.Instance.acces.GetHotels())
                {
                    List<Room> rooms = hotel.Rooms;

                    foreach (Room room in rooms)
                    {
                        room.UpdatePrice(MainMenu.Instance.currency);
                    }
                }
            }
        }
        public static void PopulateComboBox(Guna2ComboBox comboBox,Boolean full)
        {
            currencies=new List<Currency> {
                new Currency("US Dollar","USD",1.0m),
                new Currency ("Euro","EUR",0.85m),
                new Currency ("British Pound","GBP",0.72m)
                };
            if (full)
            {
                foreach(var element in currencies)
                {
                    comboBox.Items.Add(fullCurrency(element));
                }
            }
            else
            {
                foreach (var element in currencies)
                {
                    comboBox.Items.Add(element.Code);
                }
            }
        }
        public static String fullCurrency(Currency currency)
        {
            return currency.Code+" "+currency.Name;
        }
    }
}
