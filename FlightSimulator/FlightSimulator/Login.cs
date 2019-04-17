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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            /*string path = "AuthenticateUserFile.txt";
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
            {*/
                MessageBox.Show("Welcome : ","WELCOMEE!!!");
                Main_Simulator_ main = new Main_Simulator_();
                main.Show();
                this.Hide();
         /*   }
            else
            {
                MessageBox.Show("Incorrect user credentials","ERROR!!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }*/
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            forgotton_Password forgotton_ = new forgotton_Password();
            forgotton_.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
