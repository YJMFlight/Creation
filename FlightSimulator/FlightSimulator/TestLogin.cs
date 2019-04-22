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
    public partial class TestLogin : Form
    {
        public TestLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Mphiwa\source\offline rough work\YJMFlight\Creation\FlightSimulator\FlightSimulator\Resources\AuthrnticateUserFile.txt";
            string pass = txtPassword.Text;
            string ussername = txtUsername.Text;
            bool valid = false;

            Authentiction_Handler handler = new Authentiction_Handler();
            List<Users> users = handler.GetUsers(path);
            foreach (Users item in users)
            {
                string myusser = item.UserName;
                string mypass = item.Password;

                if (mypass == pass && myusser == ussername)
                {
                    valid = true;
                }

            }

            if (valid)
            {
                MessageBox.Show("Welcome : " + ussername, "WELCOMEE!!!");
               
            }
            else
            {
                MessageBox.Show("Incorrect user credentials", "ERROR!!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void TestLogin_Load(object sender, EventArgs e)
        {

        }
    }
    
}
