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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y = 0; 

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            x = e.X; //Assigning variable x to the X coordinate of the mouse whenever it moves
            y = e.Y; //Same with x

            label1.Location = new Point(x - label1.Width, y); //Not entirely sure why width is minused
                                                              //Essentially, it's moving the label to where the mouse cursor is
            label2.Location = new Point(x, y - label2.Height);
            label1.Text = x.ToString();
            label2.Text = y.ToString();
        }

    }
}
