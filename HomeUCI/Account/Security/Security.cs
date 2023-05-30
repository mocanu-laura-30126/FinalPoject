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

namespace FinalPoject.HomeUCI.Account.Security
{
    public partial class Security : UserControl
    {
        private static List<Panel> listOfPanels;
        private static Security _obj;
        public static Security Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Security();
                return _obj;
            }
        }
        public Security()
        {
            InitializeComponent();
            PopulateList();
        }
        public Panel pnlSecurity
        {
            get { return PnlSecurity; }
            set { PnlSecurity = value; }
        }

        private void PopulateList()
        {
            listOfPanels = new List<Panel>()
            {
                PnlPassword,PnlDeleteAccount
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            HomeSignedIn.Instance.pnlAccount.Controls.Add(AccountInformationButtons.Instance);
            AccountInformationButtons.Instance.Dock = DockStyle.Fill;
            AccountInformationButtons.Instance.BringToFront();
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

        private void DeactivateButtons(Guna2Button button)
        {
            BtnEditPassword.Enabled = false;
            BtnEditDA.Enabled = false;
            switch (button.Name)
            {
                case "BtnEditPassword":
                    {
                        BtnEditPassword.Enabled = true;
                        break;
                    }
                case "BtnEditDA":
                    {
                        BtnEditDA.Enabled = true;
                        break;
                    }
            }
        }
        private void ActivateButtons()
        {
            BtnEditPassword.Enabled = true;
            BtnEditDA.Enabled = true;
        }

        private void RelocatePanels(Panel pnl, int ratio, Boolean sign)
        {
            int index = listOfPanels.IndexOf(pnl);
            if (pnl == null) return;
            else
            {
                for (int i = index + 1; i < listOfPanels.Count; i++)
                {
                    if (sign)
                    {
                        listOfPanels[i].Location = new Point(listOfPanels[i].Location.X, listOfPanels[i].Location.Y + ratio);
                    }
                    else
                    {
                        listOfPanels[i].Location = new Point(listOfPanels[i].Location.X, listOfPanels[i].Location.Y - ratio);
                    }
                }
            }
        }

        private void TxtBoxPW_TextChanged(object sender, EventArgs e)
        {
            Boolean lowercase = false;
            Boolean uppercase = false;
            Boolean number = false;
            Boolean specialCharacter = false;
            foreach (char c in TxtBoxPW.Text)
            {
                if (Char.IsLower(c))
                {
                    lowercase = true;
                    PboxLowerCase.Image = null;
                    updateLabel(LblPWV, false);
                }
                else if (Char.IsUpper(c))
                {
                    uppercase = true;
                    PBoxUpperCase.Image = null;
                    updateLabel(LblPWV, false);
                }
                else if (Char.IsNumber(c))
                {
                    number = true;
                    PBoxNumber.Image = null;
                    updateLabel(LblPWV, false);
                }
                else if (!Char.IsLetterOrDigit(c))
                {
                    specialCharacter = true;
                    PboxSpecialChr.Image = null;
                    updateLabel(LblPWV, false);
                }
            }
            if (!lowercase)
            {
                PboxLowerCase.Image = GetImage("L");
                updateLabel(LblPWV, true);
            }
            if (!uppercase)
            {
                PBoxUpperCase.Image = GetImage("U");
                updateLabel(LblPWV, true);
            }
            if (!number)
            {
                PBoxNumber.Image = GetImage("N");
                updateLabel(LblPWV, true);
            }
            if (!specialCharacter)
            {
                PboxSpecialChr.Image = GetImage("S");
                updateLabel(LblPWV, true);
            }
        }

        private void updateLabel(Label label,Boolean confirm)
        {
            if(confirm)
            {
                label.ForeColor = Color.Red;
            }
            else
            {
                label.ForeColor = Color.White;
            }
            
        }

        private Image GetImage(String character)
        {
            string path="C:\\Users\\besne\\OneDrive\\Desktop\\HW\\TryingProject\\Icons\\";
            Image initialImage=Image.FromFile(path+"N.png");
            switch (character)
            {
                case "L":
                    {
                        try
                        {
                            initialImage = Image.FromFile("C:\\Users\\besne\\OneDrive\\Desktop\\HW\\TryingProject\\Icons\\L.png");
                        }
                        catch (Exception e)
                        {

                        }
                        break;
                    }
                case "U":
                    {
                        try
                        {
                            initialImage = Image.FromFile("C:\\Users\\besne\\OneDrive\\Desktop\\HW\\TryingProject\\Icons\\U.png");
                        }
                        catch (Exception e)
                        {

                        }
                        break;
                    }
                case "S":
                    {
                        try
                        {
                            initialImage = Image.FromFile("C:\\Users\\besne\\OneDrive\\Desktop\\HW\\TryingProject\\Icons\\S.png");
                        }
                        catch (Exception e)
                        {

                        }
                        break;
                    }
                case "N":
                    {
                        try
                        {
                            initialImage = Image.FromFile("C:\\Users\\besne\\OneDrive\\Desktop\\HW\\TryingProject\\Icons\\N.png");
                        }
                        catch (Exception e)
                        {

                        }
                        break;
                    }
            }
            return initialImage;
        }

        private void BtnSavePW_Click(object sender, EventArgs e)
        {
            if (LblPWV.ForeColor!=Color.Red)
            {
                if (MainMenu.User != null)
                {
                    this.BtnEditPassword_Click(sender, e);
                    try
                    {
                        Login.myCon.Open();

                        string updateQuery = "UPDATE [dbo].[User] SET Password = @password WHERE UserID = @id";
                        using (SqlCommand command = new SqlCommand(updateQuery, Login.myCon))
                        {
                            command.Parameters.AddWithValue("@password", TxtBoxPW.Text);
                            command.Parameters.AddWithValue("@id", MainMenu.User.UserID);

                            MainMenu.User.Password = TxtBoxPW.Text;

                            command.ExecuteNonQuery();
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

        private void BtnEditPassword_Click(object sender, EventArgs e)
        {
            if (BtnEditPassword.Text == "Reset")
            {
                BtnEditPassword.Text = "Cancel";
                DeactivateButtons(BtnEditPassword);
                TxtBoxPW.Visible = true;
                BtnSavePW.Visible = true;
                PnlPassword.Height = 155;
                RelocatePanels(PnlPassword, 70, true);
                LblPassword.Text = "Password";
            }
            else
            {
                ActivateButtons();
                BtnEditPassword.Text = "Reset";
                PnlPassword.Height = 102;
                RelocatePanels(PnlPassword, 70, false);
                TxtBoxPW.Visible = false;
                BtnSavePW.Visible = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (BtnConfirm.Checked)
            {
                if (MainMenu.User != null)
                {
                    this.BtnEditDA_Click(sender, e);
                    try
                    {
                        Login.myCon.Open();

                        string deleteQuery = "DELETE FROM [dbo].[User] WHERE UserID = @id";
                        using (SqlCommand command = new SqlCommand(deleteQuery, Login.myCon))
                        {
                            command.Parameters.AddWithValue("@id", MainMenu.User.UserID);
                            command.ExecuteNonQuery(); 
                            MainMenu.User = null;
                            BtnSignOut_Click(sender, e);
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

        private void BtnEditDA_Click(object sender, EventArgs e)
        {
            if (BtnEditDA.Text == "Delete")
            {
                BtnEditDA.Text = "Cancel";
                DeactivateButtons(BtnEditDA);
                BtnConfirm.Visible = true;
                BtnDelete.Visible = true;
                PnlDeleteAccount.Height = 155;
                LblConfirmation.Text = "Are you sure you want to delete this account?";
            }
            else
            {
                ActivateButtons();
                BtnConfirm.Checked = false;
                BtnEditDA.Text = "Delete";
                PnlDeleteAccount.Height = 102;
                LblConfirmation.Text = "Permanently delete your TripWise account";
                BtnConfirm.Visible = false;
                BtnDelete.Visible = false;
            }
        }
    }
}
