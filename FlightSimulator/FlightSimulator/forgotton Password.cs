using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulator
{
    public partial class forgotton_Password : Form
    {
        public forgotton_Password()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Mphiwa\source\offline rough work\YJMFlight\Creation\FlightSimulator\FlightSimulator\Resources\AuthrnticateUserFile.txt";
            string ussername = txtUsername.Text;
            string username = txtReEnter.Text;
            if (ussername == username)
            {

            
            Authentiction_Handler handler = new Authentiction_Handler();
            List<Users> users = handler.GetUsers(path);
                foreach (Users item in users)
                {
                    string myusser = item.UserName;
                    string mypass = item.Password;

                    if ( myusser == ussername)
                    {
                        txtPassword.Text = mypass;
                    }
                }
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
