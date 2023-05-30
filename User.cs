using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPoject
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public int UserID { get; set; }
        public string ImageWay { get; set; }

        public User(string userName, string password, string firstName,
            string lastName, string email, string address, string phoneNumber, int userID)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            UserID = userID;
            ImageWay = "C:\\Users\\SuportIT\\Desktop\\ghuta\\FinalPoject_2_David\\Icons2\\Letters" + "\\" + char.ToUpper(UserName[0]) + ".png";
        }
    }
}
