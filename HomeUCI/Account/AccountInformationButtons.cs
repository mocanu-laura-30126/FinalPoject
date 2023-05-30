using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.HomeUCI.Account
{
    public partial class AccountInformationButtons : UserControl
    {
        private static AccountInformationButtons _obj;
        public static AccountInformationButtons Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new AccountInformationButtons();
                return _obj;
            }
        }

        public Panel pnlMainSettings
        {
            get { return PnlMainSettings; }
            set { PnlMainSettings = value; }
        }
        public AccountInformationButtons()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPreferences_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Add(AccountInformation.Instance);
            AccountInformation.Instance.BringToFront();
            AccountInformation.Instance.BtnPActivation(sender, e);
        }

        private void BtnSecurity_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Add(AccountInformation.Instance);
            AccountInformation.Instance.BringToFront();
            AccountInformation.Instance.BtnSActivation(sender, e);
        }

        private void LinkLabelPreferences_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.BtnPreferences_Click(sender, e);
        }

        private void LinkLabelSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.BtnSecurity_Click(sender, e);  
        }

        private void BtnPDAIB_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Add(AccountInformation.Instance);
            AccountInformation.Instance.BringToFront();
            AccountInformation.Instance.BtnPDActivation(sender, e);
        }

        private void LinkLabelPD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.BtnPDAIB_Click(sender, e);
        }

        private void BtnDisplayUN_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            MainMenu.Instance.mainPanel.Controls.Clear();
            HomeSignedIn.Instance.pnlAccount.Controls.Remove(AccountInformation.Instance);
            HomeSignedIn.Instance.pnlAccount.Controls.Remove(AccountInformationButtons.Instance);
            HomeUc.Instance.Dock = DockStyle.Fill;
            MainMenu.Instance.mainPanel.Controls.Add(HomeUc.Instance);
            HomeUc.Instance.BringToFront();
        }
    }
}
