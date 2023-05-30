using FinalPoject.HomeUCI.PanelButtonUser;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace FinalPoject.HomeUCI.Account.Personal_Details
{
    public partial class PersonalDetails : UserControl
    {
        private static List<Panel> listOfPanels;
        private static PersonalDetails _obj;
        public static PersonalDetails Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new PersonalDetails();
                return _obj;
            }
        }
        public Panel pnlPD
        {
            get { return PnlPD; }
            set { PnlPD = value; }
        }


        public PersonalDetails()
        {
            InitializeComponent();
            PnlFullName.Height = 70;
            PnlUserName.Height = 70;
            PnlEmail.Height = 70;
            PnlPN.Height = 70;
            PnlAddress.Height = 70;
            if (MainMenu.User!=null)
            {
                updatedLabels();
                if (File.Exists(MainMenu.User.ImageWay))
                {
                    Image image = Image.FromFile(MainMenu.User.ImageWay);
                    PictBoxInitial.Image = image;
                }
            }
            PopulateList();
        }

        private void updatedLabels()
        {
            LblFullName.Text = MainMenu.User.FirstName + " " + MainMenu.User.LastName;
            LblUserName.Text = MainMenu.User.UserName;
            LblEmail.Text = MainMenu.User.Email;
            LblPN.Text = MainMenu.User.PhoneNumber;
            LblAddress.Text = MainMenu.User.Address;
        }
        private void PopulateList()
        {
            listOfPanels = new List<Panel>()
            {
                PnlFullName,PnlUserName,PnlEmail,PnlPN,PnlAddress
            };
        }

        private void PnlPD_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DeactivateButtons(Guna2Button button)
        {
            BtnChangeFLName.Enabled = false;
            BtnEditUN.Enabled = false;
            BtnEditEmail.Enabled = false;
            BtnEditPN.Enabled = false;
            BtnEditAddress.Enabled = false;
            switch (button.Name)
            {
                case "BtnChangeFLName":
                    {
                        BtnChangeFLName.Enabled = true;
                        break;
                    }
                case "BtnEditUN":
                    {
                        BtnEditUN.Enabled= true;
                        break;
                    }
                case "BtnEditEmail":
                    {
                        BtnEditEmail.Enabled = true;
                        break;
                    }
                case "BtnEditPN":
                    {
                        BtnEditPN.Enabled = true;
                        break;
                    }
                case "BtnEditAddress":
                    {
                        BtnEditAddress.Enabled = true;
                        break;
                    }
            }
        }
        private void ActivateButtons()
        {
            BtnChangeFLName.Enabled = true;
            BtnEditUN.Enabled = true;
            BtnEditEmail.Enabled= true;
            BtnEditPN.Enabled = true;
            BtnEditAddress.Enabled = true;
        }

        private void RelocatePanels(Panel pnl,int ratio,Boolean sign)
        {
            int index=listOfPanels.IndexOf(pnl);
            if(pnl == null) return;
            else
            {
                for(int i=index+1;i<listOfPanels.Count; i++)
                {
                    if (sign)
                    {
                        listOfPanels[i].Location = new Point(listOfPanels[i].Location.X, listOfPanels[i].Location.Y +  ratio);
                    }
                    else
                    {
                        listOfPanels[i].Location = new Point(listOfPanels[i].Location.X, listOfPanels[i].Location.Y -  ratio);
                    }
                }
            }
        }
        private void BtnChangeFLName_Click(object sender, EventArgs e)
        {
            if(BtnChangeFLName.Text=="Edit")
            {
                LblFNV.ForeColor = Color.White;
                LblLNV.ForeColor = Color.White;
                BtnChangeFLName.Text = "Cancel";
                DeactivateButtons(BtnChangeFLName);
                LblFullName.Visible= false;
                LblFirstName.Visible = true;
                LblLastName.Visible = true;
                TxtBoxFirstName.Visible = true;
                TxtBoxLastName.Visible = true;
                BtnSaveFN.Visible = true;
                PnlFullName.Height = 155;
                RelocatePanels(PnlFullName, 70, true);               
                if (MainMenu.User != null)
                {
                    TxtBoxFirstName.Text = MainMenu.User.FirstName;
                    TxtBoxLastName.Text = MainMenu.User.LastName;
                    TxtBoxFirstName.ForeColor = Color.Black;
                    TxtBoxLastName.ForeColor = Color.Black;
                }

                LblFirstName.Text = "First name(s)";
                LblLastName.Text = "Last name";
            }
            else
            {
                ActivateButtons();
                BtnChangeFLName.Text = "Edit";
                PnlFullName.Height = 102;
                RelocatePanels(PnlFullName, 70, false);
                LblFullName.Visible = true;
                LblFirstName.Visible = false;
                LblLastName.Visible = false;
                TxtBoxFirstName.Visible = false;
                TxtBoxLastName.Visible = false;
                BtnSaveFN.Visible = false;
            }
        }
        private void EditClicks(Guna2Button buttonEdit, Guna2Button buttonSave,
            Guna2TextBox textBox, Label label, Panel panel, string attribute)
        {
            if(buttonEdit.Text.Equals("Edit"))
            {
                DeactivateButtons(buttonEdit);
                buttonEdit.Text = "Cancel";
                textBox.Visible = true;
                buttonSave.Visible = true;
                panel.Height = 155;
                RelocatePanels(panel, 70, true);

                if(MainMenu.User!=null)
                {
                    textBox.ForeColor = Color.Black;
                    switch(attribute)
                    {
                    case "UserName":
                        {
                            label.Text = "Display name";
                            textBox.Text = MainMenu.User.UserName;
                            break;
                        }
                    case "Email":
                        {
                            label.Text = "Email address";
                            textBox.Text= MainMenu.User.Email;
                            break;
                        }
                    case "PhoneNumber":
                        {
                            label.Text = "Phone number";
                            textBox.Text = MainMenu.User.PhoneNumber;
                            break;
                        }
                    case "Address":
                        {
                            label.Text = "Address";
                            textBox.Text = MainMenu.User.Address;
                            break;
                        }
                    }
                }
            }
            else
            {
                ActivateButtons();
                buttonEdit.Text = "Edit";
                if (MainMenu.User != null)
                {
                    textBox.ForeColor = Color.Black;
                    switch (attribute)
                    {
                        case "UserName":
                            {
                                label.Text = MainMenu.User.UserName;
                                break;
                            }
                        case "Email":
                            {
                                label.Text = MainMenu.User.Email;
                                break;
                            }
                        case "PhoneNumber":
                            {
                                label.Text = MainMenu.User.PhoneNumber;
                                break;
                            }
                        case "Address":
                            {
                                label.Text = MainMenu.User.Address;
                                break;
                            }
                    }
                }
                panel.Height = 102;
                RelocatePanels(panel, 70, false);
                textBox.Visible = false;
                buttonSave.Visible = false;
            }
        }

        private void BtnEditUN_Click(object sender, EventArgs e)
        {
            EditClicks(BtnEditUN, BtnSaveUN, TxtBoxUN, LblUserName, PnlUserName, "UserName");
            
        }

        private void BtnEditEmail_Click_1(object sender, EventArgs e)
        {
            EditClicks(BtnEditEmail, BtnSaveEmail, TxtBoxEmail, LblEmail, PnlEmail, "Email");
        }

        private void BtnEditPN_Click(object sender, EventArgs e)
        {
            EditClicks(BtnEditPN, BtnSavePN, TxtBoxPN, LblPN, PnlPN, "PhoneNumber");
        }

        private void BtnEditAddress_Click(object sender, EventArgs e)
        {
            EditClicks(BtnEditAddress, BtnSaveAddress, TxtBoxAddress, LblAddress, PnlAddress, "Address");
        }

        private void BtnSaveFN_Click(object sender, EventArgs e)
        {
            if(LblFNV.ForeColor!=Color.Red && LblLNV.ForeColor != Color.Red)
            {
                if (MainMenu.User != null)
                {
                    this.BtnChangeFLName_Click(sender, e);

                    try
                    {
                        Login.myCon.Open();

                        string updateQuery = "UPDATE [dbo].[User] SET FirstName = @firstName, LastName = @lastName WHERE UserID = @id";
                        using (SqlCommand command = new SqlCommand(updateQuery, Login.myCon))
                        {
                            command.Parameters.AddWithValue("@firstName", TxtBoxFirstName.Text);
                            command.Parameters.AddWithValue("@lastName", TxtBoxLastName.Text);
                            command.Parameters.AddWithValue("@id", MainMenu.User.UserID);

                            MainMenu.User.FirstName = TxtBoxFirstName.Text;
                            MainMenu.User.LastName = TxtBoxLastName.Text;

                            command.ExecuteNonQuery();

                            updatedLabels();
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

        private void AlreadyInUse(Label label)
        {

        }

        private void UpdateLabelEmail(string text, Label label)
        {
        }

        private void TxtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelForeColor(TxtBoxFirstName.Text, LblFNV,true);
        }

        private void TxtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelForeColor(TxtBoxLastName.Text, LblLNV, true);
        }


        private void BtnSaveUN_Click(object sender, EventArgs e)
        {
            if (MainMenu.User != null)
            {
                if (LblUNAU.ForeColor != Color.Red)
                {
                    this.BtnEditUN_Click(sender, e);
                    try
                    {
                        Login.myCon.Open();
                        string updateQuery = "UPDATE [dbo].[User] SET UserName = @username WHERE UserID = @id";
                        using (SqlCommand command = new SqlCommand(updateQuery, Login.myCon))
                        {
                            command.Parameters.AddWithValue("@username", TxtBoxUN.Text);
                            command.Parameters.AddWithValue("@id", MainMenu.User.UserID);

                            MainMenu.User.UserName = TxtBoxUN.Text;
                            ButtonUser.Instance.btnDisplayUN.Text = TxtBoxUN.Text;
                            command.ExecuteNonQuery();
                            updatedLabels();
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

        private int searchInUser(string attribute,Guna2TextBox textBox)
        {
            Login.myCon.Open();

            string query = "SELECT COUNT(*) FROM [User] WHERE " + attribute + " = @parameter;";
            SqlCommand command = new SqlCommand(query, Login.myCon);
            command.Parameters.AddWithValue("@parameter", textBox.Text);

            int count = (int)command.ExecuteScalar();
            Login.myCon.Close();
            return count;
        }

        private void BtnSaveEmail_Click(object sender, EventArgs e)
        {
            if (LblEmailV.ForeColor!=Color.Red)
            {
                if (MainMenu.User != null)
                {
                    this.BtnEditEmail_Click_1(sender, e);
                    try
                    {
                        Login.myCon.Open();
                        string updateQuery = "UPDATE [dbo].[User] SET Email = @email WHERE UserID = @id";
                        using (SqlCommand command = new SqlCommand(updateQuery, Login.myCon))
                        {
                            command.Parameters.AddWithValue("@email", TxtBoxEmail.Text);
                            command.Parameters.AddWithValue("@id", MainMenu.User.UserID);

                            MainMenu.User.Email = TxtBoxEmail.Text;
                            command.ExecuteNonQuery();
                            updatedLabels();
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



        private void BtnSaveAddress_Click(object sender, EventArgs e)
        {
            if (MainMenu.User != null)
            {
                this.BtnEditAddress_Click(sender, e);
                try
                {
                    Login.myCon.Open();

                    string updateQuery = "UPDATE [dbo].[User] SET Address = @address WHERE UserID = @id";
                    using (SqlCommand command = new SqlCommand(updateQuery, Login.myCon))
                    {
                        command.Parameters.AddWithValue("@address", TxtBoxAddress.Text);
                        command.Parameters.AddWithValue("@id", MainMenu.User.UserID);

                        MainMenu.User.Address = TxtBoxAddress.Text;
                        updatedLabels();
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
        private void UpdateLabelEmail(String text,Label label,Boolean confirmation)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z-.]+$";
            if(Regex.IsMatch(text, emailPattern) && confirmation!=true)
            {
                label.ForeColor = Color.White;
            }
            else
            {
                label.ForeColor = Color.Red;
            }
        }
        private void UpdateLabelForeColor(string text, Label label, Boolean confirmation)
        {
            string namePattern = @"^[a-zA-Z-]+$";
            if (string.IsNullOrEmpty(text) || Regex.IsMatch(text, namePattern))
            {
                label.ForeColor = Color.White;
            }
            else
            {
                if (confirmation == true)
                {
                    label.ForeColor = Color.Red;
                }
                else
                    label.ForeColor = Color.White;
            }
        }

        private void TxtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (searchInUser("Email", TxtBoxEmail) > 0 && TxtBoxEmail.Text != MainMenu.User.Email)
            {
                LblEmailV.Text = "Email already in use";
                UpdateLabelEmail(TxtBoxEmail.Text, LblEmailV, true);
            }
            else
            {
                LblEmailV.Text = "Please provide a valid email address";
                UpdateLabelEmail(TxtBoxEmail.Text, LblEmailV, false);
            }
        }

        private void TxtBoxUN_TextChanged(object sender, EventArgs e)
        {
            if (searchInUser("UserName", TxtBoxUN) > 0 && TxtBoxUN.Text != MainMenu.User.UserName)
            {
                UpdateLabelForeColor(TxtBoxUN.Text, LblUNAU, true);
            }
            else
            {
                UpdateLabelForeColor(TxtBoxUN.Text, LblUNAU, false);
            }
        }

        private void TxtBoxPN_TextChanged(object sender, EventArgs e)
        {
            string phonePattern = @"^[0-9]+$";
            string phoneNumber = TxtBoxPN.Text;
            if (searchInUser("PhoneNumber", TxtBoxPN) > 0 && TxtBoxPN.Text != MainMenu.User.PhoneNumber)
            {
                LblPNV.Text = "Phone number already in use";
                UpdateLabelForeColor(TxtBoxPN.Text, LblPNV, true);
            }
            else
            {
                if (!Regex.IsMatch(phoneNumber, phonePattern) || phoneNumber.Length > 10)
                {
                    LblPNV.Text = "Please provide a valid phone number";
                    UpdateLabelForeColor(phoneNumber, LblPNV, true);
                }
                else
                {
                    LblPNV.Text = "";
                    UpdateLabelForeColor(phoneNumber, LblPNV, false);
                }
            }
        }

        private void BtnSavePN_Click(object sender, EventArgs e)
        {
            if (MainMenu.User != null)
            {
                if (LblPNV.ForeColor != Color.Red)
                {
                    this.BtnEditPN_Click(sender, e);
                    try
                    {
                        Login.myCon.Open();
                        string updateQuery = "UPDATE [dbo].[User] SET PhoneNumber = @phoneNumber WHERE UserID = @id";
                        using (SqlCommand command = new SqlCommand(updateQuery, Login.myCon))
                        {
                            command.Parameters.AddWithValue("@phoneNumber", TxtBoxPN.Text);
                            command.Parameters.AddWithValue("@id", MainMenu.User.UserID);

                            MainMenu.User.PhoneNumber = TxtBoxPN.Text;
                            command.ExecuteNonQuery();
                            updatedLabels();
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
    }
}
