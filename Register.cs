using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FinalPoject
{
    public partial class Register : Form
    {
        SqlConnection myCon;
        Image initialImage = Image.FromFile("C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\Icons2\\GrayCircle.png");
        Image image = Image.FromFile("C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\Icons2\\GreenCirlce.png");
        private const int cGrip = 16;
        private const int cCaption = 32;
        public Register()
        {
            InitializeComponent();
        }
        public Register(String connection)
        {
            InitializeComponent();
            myCon = new SqlConnection(connection);
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlRegisterP2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnShowPassword_Click_1(object sender, EventArgs e)
        {
            if (TxtRegisterPW.PasswordChar == '*')
            {
                BtnHidePassword.BringToFront();
                TxtRegisterPW.PasswordChar = '\0';
            }
        }

        private void BtnHidePassword_Click_1(object sender, EventArgs e)
        {
            if (TxtRegisterPW.PasswordChar == '\0')
            {
                BtnShowPassword.BringToFront();
                TxtRegisterPW.PasswordChar = '*';
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void BtnBackRegister_Click(object sender, EventArgs e)
        {
            PnlRegisterP2.Height = 10;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z-.]+$";
            if (Regex.IsMatch(TxtEmail.Text, emailPattern))
            {
                int count = searchInUser(TxtEmail);
                if (count > 0)
                {
                    LblEmailVerification.Text = "Email already in use";
                    LblEmailVerification.ForeColor = Color.Red;
                }
                else if(LblFirstNameVerify.ForeColor!=Color.Red && LblLastNameVerify.ForeColor != Color.Red
                    && LblUsernameVerify.ForeColor != Color.Red)
                {
                    LblEmailVerification.ForeColor = Color.FromArgb(0, 112, 220);
                    PnlRegisterP2.Height = PnlRegisterP1.Height;
                    PnlRegisterP2.BringToFront();
                }
            }
            else
            {
                LblEmailVerification.ForeColor = Color.Red;
                LblEmailVerification.Text = "Please enter a valid Email address";
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtRegisterPW_TextChanged(object sender, EventArgs e)
        {
            Boolean lowercase = false;
            Boolean uppercase = false;
            Boolean number = false;
            Boolean specialCharacter = false;
            foreach (char c in TxtRegisterPW.Text)
            {
                if (Char.IsLower(c))
                {
                    lowercase = true;
                    LblLowercase.Image = image;
                }
                else if (Char.IsUpper(c))
                {
                    uppercase = true;
                    LblUppercase.Image = image;
                }
                else if (Char.IsNumber(c))
                {
                    number = true;
                    LblNumber.Image = image;
                }
                else if (!Char.IsLetterOrDigit(c))
                {
                    specialCharacter = true;
                    LblSpecialCharacter.Image = image;
                }
            }
            if (!lowercase)
            {
                LblLowercase.Image = initialImage;
            }
            if (!uppercase)
            {
                LblUppercase.Image = initialImage;
            }
            if (!number)
            {
                LblNumber.Image = initialImage;
            }
            if (!specialCharacter)
            {
                LblSpecialCharacter.Image = initialImage;
            }
        }

        private void LblLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {}

        private void TxtRegisterCPW_TextChanged(object sender, EventArgs e)
        {
            //if(TxtRegisterCPW.Text.Equals(TxtRegisterPW.Text))
            //{
            //    LblMatchingPasswords.ForeColor = Color.FromArgb(0, 112, 220);
            //}
            //else
            //{
            //    LblMatchingPasswords.ForeColor = Color.Red;
            //}
        }

        private void TxtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if(TxtPhoneNumber.Text.Any(c =>!Char.IsDigit(c)))
            {
                LblPhoneNrVerify.ForeColor = Color.Red;
            }
            else
                LblPhoneNrVerify.ForeColor = Color.FromArgb(0, 112, 220);

            if (TxtPhoneNumber.Text.Length>10)
            {
                LblPhoneNrLength.ForeColor = Color.Red;
            }
            else
                LblPhoneNrLength.ForeColor = Color.FromArgb(0, 112, 220);
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            int count = searchInUser(TxtUserName);
            if (count > 0)
            {
                LblUsernameVerify.ForeColor=Color.Red;
            }
            else
            {
                LblUsernameVerify.ForeColor = Color.FromArgb(0, 112, 220);
            }
        }

        private int searchInUser(Guna2TextBox textBox)
        {
            string originalString = textBox.Name;
            string prefix = "Txt";

            int startIndex = originalString.IndexOf(prefix) + prefix.Length;

            string extractedString = originalString.Substring(startIndex);

            myCon.Open();
            
            string query = "SELECT COUNT(*) FROM [User] WHERE "+extractedString+" = @parameter;";
            SqlCommand command = new SqlCommand(query, myCon);
            command.Parameters.AddWithValue("@parameter", textBox.Text);

            int count = (int)command.ExecuteScalar();
            myCon.Close();
            return count;
        }

        private void PnlRegisterP1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            string namePattern = @"^[a-zA-Z-]+$";
            if (Regex.IsMatch(TxtFirstName.Text, namePattern))
            {
                LblFirstNameVerify.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                LblFirstNameVerify.ForeColor = Color.Red;
            }
        }


        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            string namePattern = @"^[a-zA-Z-]+$";
            if (Regex.IsMatch(TxtLastName.Text, namePattern))
            {
                LblLastNameVerify.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                LblLastNameVerify.ForeColor = Color.Red;
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (TxtPhoneNumber.Text.Length <= 0)
            {
                int count = searchInUser(TxtPhoneNumber);
                if (count > 0)
                {
                    LblPhoneNrVerify.Text = "Phone number already in use";
                    LblPhoneNrVerify.ForeColor = Color.Red;
                }
                else
                {
                    LblPhoneNrVerify.Text = "Please introduce a valid phone number";
                    LblPhoneNrVerify.ForeColor = Color.Red;
                }
            }
            if (TxtRegisterCPW.Text.Equals(TxtRegisterPW.Text))
            {
                LblMatchingPasswords.ForeColor = Color.FromArgb(0, 112, 220);
            }
            else
            {
                LblMatchingPasswords.ForeColor = Color.Red;
            }
            if (LblPhoneNrVerify.ForeColor != Color.Red && LblPhoneNrLength.ForeColor != Color.Red
                && LblMatchingPasswords.ForeColor != Color.Red && LblLowercase.Image == image
                && LblUppercase.Image == image && LblSpecialCharacter.Image == image && LblNumber.Image == image)
            {
                myCon.Open();

                string query = @"INSERT INTO [dbo].[User] ([UserName], [FirstName], [LastName], [Email], [Password], [PhoneNumber], [Address]) 
                     VALUES (@UserName, @FirstName, @LastName, @Email, @Password, @PhoneNumber, @Address)";

                SqlCommand command = new SqlCommand(query, myCon);
                command.Parameters.AddWithValue("@UserName", TxtUserName.Text);
                command.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                command.Parameters.AddWithValue("@LastName", TxtLastName.Text);
                command.Parameters.AddWithValue("@Email", TxtEmail.Text);
                command.Parameters.AddWithValue("@Password", TxtRegisterPW.Text);
                command.Parameters.AddWithValue("@PhoneNumber", TxtPhoneNumber.Text);
                command.Parameters.AddWithValue("@Address", TxtAddress.Text);

                command.ExecuteNonQuery();

                myCon.Close();
                this.Close();
            }
        }

        private void LblFirstNameVerify_Click(object sender, EventArgs e)
        {

        }
    }
}
