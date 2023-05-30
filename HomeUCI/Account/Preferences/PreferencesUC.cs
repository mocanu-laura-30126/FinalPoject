using FinalPoject.HomeUCI.Account.Personal_Details;
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

namespace FinalPoject.HomeUCI.Account.Preferences
{
    public partial class PreferencesUC : UserControl
    {
        private static PreferencesUC _obj;
        public static PreferencesUC Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new PreferencesUC();
                return _obj;
            }
        }

        public Panel pnlPreferences
        {
            get { return PnlPreferences; }
            set { PnlPreferences = value; }
        }


        public PreferencesUC()
        {
            InitializeComponent();
            HomeSignedIn.PopulateComboBox(CmbBoxCurrencyP, true);
            if (MainMenu.Instance.currency != null)
            {
                LblCurrency.Text = HomeSignedIn.fullCurrency(MainMenu.Instance.currency);
            }
            PnlCurrency.Height = 70;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEditCurrency_Click(object sender, EventArgs e)
        {
            if (BtnEditCurrency.Text == "Edit")
            {
                if (MainMenu.Instance.currency != null)
                {
                    LblCurrency.Text = HomeSignedIn.fullCurrency(MainMenu.Instance.currency);
                }
                else
                {
                    LblCurrency.Text = "Currency";
                }
                BtnEditCurrency.Text = "Cancel";
                LblCurrency.Visible = true;
                CmbBoxCurrencyP.Visible = true;
                BtnSaveCurrency.Visible = true;
                PnlCurrency.Height = 155;

            }
            else
            {
                BtnEditCurrency.Text = "Edit";
                PnlCurrency.Height = 102;
                CmbBoxCurrencyP.Visible = false;
                BtnSaveCurrency.Visible = false;
            }
        }

        private void CmbBoxCurrencyP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveCurrency_Click(object sender, EventArgs e)
        {
            if (MainMenu.User != null)
            {
                {
                    this.BtnEditCurrency_Click(sender, e);
                    try
                    {
                        Login.myCon.Open();
                        if (CmbBoxCurrencyP.SelectedItem != null)
                        {
                            string[] code = CmbBoxCurrencyP.SelectedItem.ToString().Split(' ');
                            LblCurrency.Text = code[0]+" "+code[1];
                            Currency currency = HomeSignedIn.Instance.GetCurrencies().Find(c => c.Code == code[0]);
                            MainMenu.Instance.currency = currency;
                            int index = HomeSignedIn.Instance.cmbCurrency.FindStringExact(code[0]);

                            if (index != ListBox.NoMatches)
                            {
                                HomeSignedIn.Instance.cmbCurrency.SelectedIndex = index;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    finally
                    {
                        Login.myCon.Close();
                    }
                }
            }
        }

        private void LblCurrency_Click(object sender, EventArgs e)
        {

        }
    }
}
