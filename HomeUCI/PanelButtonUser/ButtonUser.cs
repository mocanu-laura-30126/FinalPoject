using FinalPoject.HomeUCI.Account;
using FinalPoject.HomeUCI.Account.Bookings;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace FinalPoject.HomeUCI.PanelButtonUser
{
    public partial class ButtonUser : UserControl
    {
        private static ButtonUser _obj;
        public static ButtonUser Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new ButtonUser();
                return _obj;
            }
        }
        public Guna2Button btnDisplayUN
        {
            get { return BtnDisplayUN; }
            set { BtnDisplayUN = value; }
        }
        public ButtonUser()
        {
            InitializeComponent();
            if (MainMenu.User != null)
            {
                BtnDisplayUN.Text = MainMenu.User.UserName;
                if (File.Exists(MainMenu.User.ImageWay))
                {
                    Image image = Image.FromFile(MainMenu.User.ImageWay);
                    HomeSignedIn.Instance.btnDropDown.Image= image;
                }
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Add(AccountInformationButtons.Instance);
            AccountInformationButtons.Instance.Dock = DockStyle.Fill;
            AccountInformationButtons.Instance.BringToFront();
            AccountInformationButtons.Instance.pnlMainSettings.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location= new Point(654, 6);
            ButtonUser.Instance.Height = 0;
            ButtonUser.Instance.BringToFront();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            MainMenu.Instance.mainPanel.Controls.Clear();
            HomeUc.Instance.Dock = DockStyle.Fill;
            MainMenu.Instance.mainPanel.Controls.Add(HomeUc.Instance);
            HomeUc.Instance.BringToFront();
            Login.IsLoggedIn = false;
        }

        private void BtnDisplayUN_Click(object sender, EventArgs e)
        {

        }

        private void BtnBookings_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Add(MyBooking.Instance);
            MyBooking.Instance.Dock = DockStyle.Fill;
            MyBooking.Instance.BringToFront();
            MyBooking.Instance.pnlMainInfo.Controls.Add(ButtonUser.Instance);
            ButtonUser.Instance.Location = new Point(446, 11);
            ButtonUser.Instance.Height = 0;
            ButtonUser.Instance.BringToFront();
        }
    }
}
