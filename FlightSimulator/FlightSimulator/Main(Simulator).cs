using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading;

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

        int movePlaneX, cnt = 0;
        float movePlaneY = 1f;

        private void timePlaneMove_Tick(object sender, EventArgs e)
        {
            picPlaneMap.Location = new Point(picPlaneMap.Location.X - 3, picPlaneMap.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabPage2;
        }

        int x, y = 0;

        private void Main_Simulator__Load(object sender, EventArgs e)
        {

        }

        List<int> Co_OrdinatesShoot = new List<int>();
        int ShootYOne = 0;
        int ShootYTwo = 0;
        int ShootYThree = 0;
        int ShootYFour = 0;
        int ShootYFive = 0;



        private void button3_Click(object sender, EventArgs e)
        {
            double NumberofObstacles = Convert.ToDouble(numudObstacles.Value);
            List<int> Co_ordinates = new List<int>();
         

            int XCo_ordinate = 0;
            int YCo_ordinate = 0;
            int XCo_OrdinateShoot = 0;
            int YCo_OrdinateShoot = 0;


            string XCo_OrdinateCheck = "";
            string YCo_OrdinateCheck = "";
            int ValidNumber;

            bool ValidX = false;
            bool ValidY = false;


            for (int i = 0; i < NumberofObstacles; i++)
            {
                XCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate X:", "Valid co-ordinate: 0 - 540");
                YCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate Y:", "Valid co-ordinate: 191 - 525");

                    ValidX = Int32.TryParse(XCo_OrdinateCheck, out ValidNumber);
                    ValidY = Int32.TryParse(YCo_OrdinateCheck, out ValidNumber);
                
                while (ValidX == false || ValidY == false)
                {
                    MessageBox.Show("These entries aren't valid. May we have real numbers?");

                    XCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate X:", "Valid co-ordinate: 0 - 640");
                    YCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate Y:", "Valid co-ordinate: 191 - 525");

                    ValidX = Int32.TryParse(XCo_OrdinateCheck, out ValidNumber);
                    ValidY = Int32.TryParse(YCo_OrdinateCheck, out ValidNumber);
                }

                XCo_ordinate = Convert.ToInt32(XCo_OrdinateCheck);
                YCo_ordinate = Convert.ToInt32(YCo_OrdinateCheck);

              

                while ((XCo_ordinate < 0 || XCo_ordinate > 640) && (YCo_ordinate < 191 || YCo_ordinate > 552))
                {
                    MessageBox.Show("Co_ordinates for Obstacle " + (i + 1) + " are out of bounds! Re-enter.");
                    XCo_ordinate = Convert.ToInt32(Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate X:", "Valid co-ordinate: 0 - 640"));
                    YCo_ordinate = Convert.ToInt32(Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate Y:", "Valid co - ordinate: 191 - 552"));

                  
                }

               Co_ordinates.Add(XCo_ordinate);
               Co_ordinates.Add(YCo_ordinate);

                XCo_OrdinateShoot = XCo_ordinate + 3;
                YCo_OrdinateShoot = YCo_ordinate - 10;

                Co_OrdinatesShoot.Add(XCo_OrdinateShoot);
               Co_OrdinatesShoot.Add(YCo_OrdinateShoot);
                
               XCo_ordinate = 0;
               YCo_ordinate = 0;

                XCo_OrdinateShoot = 0;
                YCo_OrdinateShoot = 0;
            }

            Thread shooter_1 = new Thread(delegate () {

                ShootYOne = Co_OrdinatesShoot[1];
                for (int i = 0; i < 10; i++)
                {
                    ShootYOne = ShootYOne - 3;
                    ShootOne();
                    Thread.Sleep(500);
                }
            });

            Thread shooter_2 = new Thread(delegate () {

                //ShootYTwo = Co_OrdinatesShoot[3];
                for (int i = 0; i < 10; i++)
                {
                    ShootYTwo = ShootYTwo - 3;
                    ShootTwo();
                    Thread.Sleep(500);
                }
            });

            Thread shooter_3 = new Thread(delegate () {

                ShootYThree = Co_OrdinatesShoot[5];
                for (int i = 0; i < 10; i++)
                {
                    ShootYThree = ShootYThree - 3;
                    ShootThree();
                    Thread.Sleep(500);
                }
            });

            Thread shooter_4 = new Thread(delegate () {

                ShootYFour = Co_OrdinatesShoot[7];
                for (int i = 0; i < 10; i++)
                {
                    ShootYFour = ShootYFour - 3;
                    ShootFour();
                    Thread.Sleep(500);
                }
            });

            Thread shooter_5 = new Thread(delegate () {
                
                ShootYFive = Co_OrdinatesShoot[9];
                for ( int i = 0; i < 10; i++)
                {
                    ShootYFive = ShootYFive - 3;
                    ShootFive();
                    Thread.Sleep(500);
                }
            });





            switch (NumberofObstacles)
            {
                case 1:

                    picObstacle1.Visible = true;
                    picObstacle1.Location = new Point(Co_ordinates[0], Co_ordinates[1]);

                    picShoot1.Location = new Point(Co_OrdinatesShoot[0], Co_OrdinatesShoot[1]);
                    picShoot1.Visible = true;
                    shooter_1.Start();
                    break;

                case 2:
                    picObstacle1.Visible = true;
                    picObstacle1.Location = new Point(Co_ordinates[0], Co_ordinates[1]);
                    picShoot1.Location = new Point(Co_OrdinatesShoot[0], Co_OrdinatesShoot[1]);

                    picObstacle2.Visible = true;
                    picObstacle2.Location = new Point(Co_ordinates[2], Co_ordinates[3]);
                    picShoot2.Location = new Point(Co_OrdinatesShoot[2], Co_OrdinatesShoot[3]);

                    picShoot1.Visible = true;
                    picShoot2.Visible = true;

                    shooter_1.Start();
                    shooter_2.Start();
                    break;

                case 3:
                    picObstacle1.Visible = true;
                    picObstacle1.Location = new Point(Co_ordinates[0], Co_ordinates[1]);
                    picShoot1.Location = new Point(Co_OrdinatesShoot[0], Co_OrdinatesShoot[1]);

                    picObstacle2.Visible = true;
                    picObstacle2.Location = new Point(Co_ordinates[2], Co_ordinates[3]);
                    picShoot2.Location = new Point(Co_OrdinatesShoot[2], Co_OrdinatesShoot[3]);

                    picObstacle3.Visible = true;
                    picObstacle3.Location = new Point(Co_ordinates[4], Co_ordinates[5]);
                    picShoot3.Location = new Point(Co_OrdinatesShoot[4], Co_OrdinatesShoot[5]);

                    picShoot1.Visible = true;
                    picShoot2.Visible = true;
                    picShoot3.Visible = true;

                    shooter_1.Start();
                    shooter_2.Start();
                    shooter_3.Start();

                    break;

                case 4:
                    picObstacle1.Visible = true;
                    picObstacle1.Location = new Point(Co_ordinates[0], Co_ordinates[1]);
                    picShoot1.Location = new Point(Co_OrdinatesShoot[0], Co_OrdinatesShoot[1]);

                    picObstacle2.Visible = true;
                    picObstacle2.Location = new Point(Co_ordinates[2], Co_ordinates[3]);
                    picShoot2.Location = new Point(Co_OrdinatesShoot[3], Co_OrdinatesShoot[4]);

                    picObstacle3.Visible = true;
                    picObstacle3.Location = new Point(Co_ordinates[4], Co_ordinates[5]);
                    picShoot3.Location = new Point(Co_OrdinatesShoot[4], Co_OrdinatesShoot[5]);

                    picObstacle4.Visible = true;
                    picObstacle4.Location = new Point(Co_ordinates[6], Co_ordinates[7]);
                    picShoot4.Location = new Point(Co_OrdinatesShoot[6], Co_OrdinatesShoot[7]);

                    picShoot1.Visible = true;
                    picShoot2.Visible = true;
                    picShoot3.Visible = true;
                    picShoot4.Visible = true;

                    shooter_1.Start();
                    shooter_2.Start();
                    shooter_3.Start();
                    shooter_4.Start();


                    break;

                case 5:
                    picObstacle1.Visible = true;
                    picObstacle1.Location = new Point(Co_ordinates[0], Co_ordinates[1]);
                    picShoot1.Location = new Point(Co_OrdinatesShoot[0], Co_OrdinatesShoot[1]);

                    picObstacle2.Visible = true;
                    picObstacle2.Location = new Point(Co_ordinates[2], Co_ordinates[3]);
                    picShoot2.Location = new Point(Co_OrdinatesShoot[2], Co_OrdinatesShoot[3]);

                    picObstacle3.Visible = true;
                    picObstacle3.Location = new Point(Co_ordinates[4], Co_ordinates[5]);
                    picShoot3.Location = new Point(Co_OrdinatesShoot[4], Co_OrdinatesShoot[5]);

                    picObstacle4.Visible = true;
                    picObstacle4.Location = new Point(Co_ordinates[6], Co_ordinates[7]);
                    picShoot4.Location = new Point(Co_OrdinatesShoot[6], Co_OrdinatesShoot[7]);

                    picObstacle5.Visible = true;
                    picObstacle5.Location = new Point(Co_ordinates[8], Co_ordinates[9]);
                    picShoot5.Location = new Point(Co_OrdinatesShoot[8], Co_OrdinatesShoot[9]);

                    picShoot1.Visible = true;
                    picShoot2.Visible = true;
                    picShoot3.Visible = true;
                    picShoot4.Visible = true;
                    picShoot5.Visible = true;


                    shooter_1.Start();
                    shooter_2.Start();
                    shooter_3.Start();
                    shooter_4.Start();
                    shooter_5.Start();



                    break;

                default:
                    break;

                   
            }

            btnSetUpObstacles.Enabled = false;

        }

       
     

        private void btnProceedPlanView_Click(object sender, EventArgs e)
        {
            
            
           
           
           
        }

        private void timeShoot1_Tick(object sender, EventArgs e)
        {
            int count = 0;
            int YLocation = picShoot1.Location.Y;

            picShoot1.Location = new Point(picShoot1.Location.X, picShoot1.Location.Y - 3);
            count = count + 1;

            if (count == 10)
            {
                picShoot1.Location = new Point(picShoot1.Location.X, Co_OrdinatesShoot[1]);
            }
            
           
        }

       


        private void button3_Click_1(object sender, EventArgs e)
        {
            timePlaneMove.Interval = 100;
            timePlaneMove.Start();
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

        public delegate void Action();

        public void ShootOne()
        {
            if (this.picShoot1.InvokeRequired)
            {
                Action act = new Action(ShootOne);
                this.Invoke(act);
            }
            else
            {

                this.picShoot1.Location = new Point(Co_OrdinatesShoot[0], ShootYOne );
      
            }
        }


        public void ShootTwo()
        {
            if (this.picShoot2.InvokeRequired)
            {
                Action act = new Action(ShootTwo);
                this.Invoke(act);
            }
            else
            {

                this.picShoot2.Location = new Point(Co_OrdinatesShoot[2], ShootYTwo);

            }
        }


        public void ShootThree()
        {
            if (this.picShoot3.InvokeRequired)
            {
                Action act = new Action(ShootThree);
                this.Invoke(act);
            }
            else
            {

                this.picShoot3.Location = new Point(Co_OrdinatesShoot[4], ShootYThree);

            }
        }

        int speed = 0;
        int alitude = 0;

        private void btnAlter_Click(object sender, EventArgs e)
        {
            

        }

        private void tabPlane_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public void ShootFour()
        {
            if (this.picShoot4.InvokeRequired)
            {
                Action act = new Action(ShootFour);
                this.Invoke(act);
            }
            else
            {

                this.picShoot4.Location = new Point(Co_OrdinatesShoot[6], ShootYFour);

            }
        }


        public void ShootFive()
        {
            if (this.picShoot5.InvokeRequired)
            {
                Action act = new Action(ShootFive);
                this.Invoke(act);
            }
            else
            {

                this.picShoot5.Location = new Point(Co_OrdinatesShoot[8], ShootYFive);

            }
        }
    }
}
