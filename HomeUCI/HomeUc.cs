using FinalPoject.HomeUCI.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject.HomeUCI
{
    public partial class HomeUc : UserControl
    {
        private static HomeUc _obj;
        public static HomeUc Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new HomeUc();
                return _obj;
            }
        }
        public HomeUc()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }
    }
}
