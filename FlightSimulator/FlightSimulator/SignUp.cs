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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Mphiwa\source\offline rough work\YJMFlight\Creation\FlightSimulator\FlightSimulator\Resources\AuthrnticateUserFile.txt";
            string name, surname, age, id, password, rank;

            name = txtName.Text;
            surname = txtSurname.Text;
            age = txtAge.Text;
            id = txtID.Text;
            rank = txtPosition.Text;
            password = txtPassword.Text;

            Users users = new Users(name, password, id, rank, surname, age);
            Authentiction_Handler handler = new Authentiction_Handler();
            handler.WriteUsers(users, path);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Main_Simulator_ main = new Main_Simulator_();
            main.Show();
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestLogin test = new TestLogin();
            test.Show();
            this.Hide();
        }
    }
}
