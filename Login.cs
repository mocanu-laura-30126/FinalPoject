using FinalPoject.HomeUCI;
using FinalPoject.HomeUCI.Account;
using FinalPoject.HomeUCI.Account.Personal_Details;
using FinalPoject.HomeUCI.Account.Preferences;
using FinalPoject.HomeUCI.PanelButtonUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject
{
    public partial class Login : Form
    {
        public static Boolean IsLoggedIn { get; set; }
        public static SqlConnection myCon;
        private const int cGrip = 16;
        private const int cCaption = 32;
        public Login()
        {
            InitializeComponent();
            myCon = new SqlConnection("Data Source=DESKTOP-4RB4PAI\\SQLEXPRESS;Initial Catalog=TripWise;Integrated Security=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
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

        private void LblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm =new Register(myCon.ConnectionString);
            registerForm.ShowDialog();
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            myCon.Open();
            string username = TxtUsernameLogin.Text;
            string password = TxtPasswordLogin.Text;
            string email = TxtUsernameLogin.Text;

            string query = "SELECT * FROM [User] WHERE (UserName = @username OR Email = @username) AND Password = @password;";

            SqlCommand command = new SqlCommand(query, myCon);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string foundUsername = reader["UserName"].ToString();
                string foundEmail = reader["Email"].ToString();
                string foundFirstName = reader["FirstName"].ToString();
                string foundLastName = reader["LastName"].ToString();
                string foundAddress = reader["Address"].ToString();
                string foundPassword = reader["Password"].ToString();
                int foundUserID = Convert.ToInt32(reader["UserID"].ToString());
                string foundPhoneNumber = reader["PhoneNumber"].ToString();
                User user = new User(foundUsername,foundPassword,foundFirstName,foundLastName,foundEmail,foundAddress,foundPhoneNumber,foundUserID);
                MainMenu.User = user;

                MainMenu.Instance.mainPanel.Controls.Clear();
                HomeSignedIn.Instance.Dock = DockStyle.Fill;
                MainMenu.Instance.mainPanel.Controls.Add(HomeSignedIn.Instance);
                HomeSignedIn.Instance.pnlAccount.Controls.Add(ButtonUser.Instance);
                ButtonUser.Instance.Location= new Point(654, 6);
                HomeSignedIn.Instance.BringToFront();
                this.Close();
                IsLoggedIn=true;
            }
            else
            {
                LblLoginVerify.ForeColor = Color.Red;
                TxtUsernameLogin.Clear();
                TxtPasswordLogin.Clear();
            }
            myCon.Close();
        }
        private void BtnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
