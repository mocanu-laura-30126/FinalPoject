using FinalPoject.HomeUCI.Account.Personal_Details;
using FinalPoject.HomeUCI.Account.Preferences;
using FinalPoject.HomeUCI.Account.Security;
using FinalPoject.HomeUCI.PanelButtonUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.HomeUCI.Account
{
    public partial class AccountInformation : UserControl
    {
        private static AccountInformation _obj;
        public static AccountInformation Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new AccountInformation();
                return _obj;
            }
        }
        public Panel pnlDetails
        {
            get { return PnlDetails; }
            set { PnlDetails = value; }
        }
        public AccountInformation()
        {
            InitializeComponent();
        }

        private void PnlMyAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPersonalDetails_Click(object sender, EventArgs e)
        {
            BtnPDActivation(sender,e);
        }
        private void BtnPersonalDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BtnPersonalDetails.Checked)
            {
                this.BtnPersonalDetails.Font = new Font(BtnPersonalDetails.Font, FontStyle.Underline);
                this.BtnPersonalDetails.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnPersonalDetails.Font = new Font(BtnPersonalDetails.Font, FontStyle.Regular);
                this.BtnPersonalDetails.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }

        public void ActivateButtonUser()
        {
            ButtonUser.Instance.Location = new Point(446, 11);
            ButtonUser.Instance.BringToFront();
            ButtonUser.Instance.Height = 0;
        }

        public void BtnPDActivation(object sender, EventArgs e)
        {
            PersonalDetails.Instance.Dock = DockStyle.Fill;
            this.pnlDetails.Controls.Add(PersonalDetails.Instance);
            PersonalDetails.Instance.BringToFront();
            PersonalDetails.Instance.pnlPD.Controls.Add(ButtonUser.Instance);
            ActivateButtonUser();
            this.BtnPersonalDetails.Checked= true;
        }

        private void BtnPreferences_Click(object sender, EventArgs e)
        {
            BtnPActivation(sender, e);
        }

        public void BtnPreferences_CheckChanged(object sender,EventArgs e)
        {
            if (this.BtnPreferences.Checked)
            {
                this.BtnPreferences.Font = new Font(BtnPreferences.Font, FontStyle.Underline);
                this.BtnPreferences.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnPreferences.Font = new Font(BtnPreferences.Font, FontStyle.Regular);
                this.BtnPreferences.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }

        public void BtnPActivation(object sender, EventArgs e)
        {
            PreferencesUC.Instance.Dock = DockStyle.Fill;
            this.pnlDetails.Controls.Add(PreferencesUC.Instance);
            PreferencesUC.Instance.BringToFront();
            PreferencesUC.Instance.pnlPreferences.Controls.Add(ButtonUser.Instance);
            ActivateButtonUser();
            this.BtnPreferences.Checked= true;
        }

        private void BtnSecurity_Click(object sender, EventArgs e)
        {
            BtnSActivation(sender, e);
        }

        public void BtnSecurity_CheckChanged(object sender, EventArgs e)
        {
            if (this.BtnSecurity.Checked)
            {
                this.BtnSecurity.Font = new Font(BtnSecurity.Font, FontStyle.Underline);
                this.BtnSecurity.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                this.BtnSecurity.Font = new Font(BtnSecurity.Font, FontStyle.Regular);
                this.BtnSecurity.ForeColor = Color.FromArgb(26, 26, 26);
            }
        }
        public void BtnSActivation(object sender, EventArgs e)
        {
            Security.Security.Instance.Dock = DockStyle.Fill;
            this.pnlDetails.Controls.Add(Security.Security.Instance);
            Security.Security.Instance.BringToFront();
            Security.Security.Instance.pnlSecurity.Controls.Add(ButtonUser.Instance);
            ActivateButtonUser();
            //this.BtnSecurity.Checked= true;
            this.BtnSecurity.Checked = true;
        }
    }
}
