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
