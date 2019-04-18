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
    public partial class Main_Simulator_ : Form
    {
        public Main_Simulator_()
        {
            InitializeComponent();
           

        }

        private Point MouseDownLocation;

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void timePlaneMove_Tick(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabPage2;
        }

        int x, y = 0;

        private void Main_Simulator__Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox4.Left = e.X + pictureBox4.Left - MouseDownLocation.X;
                pictureBox4.Top = e.Y + pictureBox4.Top - MouseDownLocation.Y;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.X;
            y = e.Y;

            Location1.Location = new Point(x - Location1.Width, y);
            Location2.Location = new Point(x, y - Location2.Height);
            Location1.Text = x.ToString();
            Location2.Text = y.ToString();
        }
    }
}
