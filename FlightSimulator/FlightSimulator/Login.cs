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
            List<Users> uc = new List<Users>();
            Users usc = new Users();

            uc = usc.GetUsers();

            string username = txtUsername.Text;
            string password = txtPassword.Text;
           

            bool ValidChecker = false;

            try
            {
                foreach (Users item in uc)
                {
                    if (username == item.UserName && password == item.Password)
                    {
                        ValidChecker = true;
                    }
                    
                }

                if (ValidChecker)
                {
                    Main_Simulator_ open = new Main_Simulator_();
                    open.Show();
                    this.Hide();
                }
                else
                {
                    throw new CustomExeption("Invalid Credentials");
                }

            }


            catch (CustomExeption custom)
            {

                MessageBox.Show(custom.Message);
            }



            
              
        }

                //MessageBox.Show("Welcome : ","WELCOMEE!!!");
                //Main_Simulator_ main = new Main_Simulator_();
                //main.Show();
                //this.Hide();
         
        

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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
