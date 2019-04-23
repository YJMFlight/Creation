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



        private void timePlaneMove_Tick(object sender, EventArgs e)
        {
            while(picPlaneMap.Location.X > 0)
            {
                picPlaneMap.Location = new Point(picPlaneMap.Location.X - 3, picPlaneMap.Location.Y);
                int Shoot1 = picObstacle1.Location.Y;
                switch (NumberofObstacles)
                {
                    case 1:
                        if (picPlaneMap.Location.X - picShoot1.Location.X < 10)
                        {
                            Shoot1 = picPlaneMap.Location.Y + 10;

                        }
                        break;
                    default:
                        break;
                }
            }

           
            while (picPlaneMap.Location.X < 790)
            {
                picPlaneMap.Location = new Point(picPlaneMap.Location.X + 3, picPlaneMap.Location.Y);

                if (picPlaneMap.Location.X > 780)
                {
                    timePlaneMove.Stop();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabPlaneSpecs;
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



        int shooter_one_count = 30;
        int shooter_two_count = 20;
        int shooter_three_count = 10;
        int shooter_four_count = 25;
        int shooter_five_count = 35;

        double NumberofObstacles = 0;

        List<int> Co_ordinates = new List<int>();
        int XCo_Ordinate,YCo_Ordinate;


        private void button3_Click(object sender, EventArgs e)
        {
            NumberofObstacles = Convert.ToDouble(numudObstacles.Value);

            if (numudObstacles.Value ==1)
            {
                for (int i = 0; i < numudObstacles.Value; i++)
                {
                    Co_ordinates[0] = XCo_Ordinate;
                    Co_ordinates[1] = YCo_Ordinate;
                    string insert = "INSERT INTO tbl_obstacle () values()";
                }
            }
            else
            {
                for (int i = 0; i < numudObstacles.Value; i++)
                {
                    Co_ordinates[0 + i + i] = XCo_Ordinate;
                    Co_ordinates[1 + i + i] = YCo_Ordinate;
                    
                }
            }

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
                XCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate X:", "Valid co-ordinate: 218 - 676");
                YCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate Y:", "Valid co-ordinate: 186 - 552");

                ValidX = Int32.TryParse(XCo_OrdinateCheck, out ValidNumber);
                ValidY = Int32.TryParse(YCo_OrdinateCheck, out ValidNumber);

                while (ValidX == false || ValidY == false)
                {
                    MessageBox.Show("These entries aren't valid. May we have real numbers?");

                    XCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate X:", "Valid co - ordinate: 218 - 676");
                    YCo_OrdinateCheck = Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate Y:", "Valid co-ordinate: 186 - 552");

                    ValidX = Int32.TryParse(XCo_OrdinateCheck, out ValidNumber);
                    ValidY = Int32.TryParse(YCo_OrdinateCheck, out ValidNumber);
                }

                XCo_ordinate = Convert.ToInt32(XCo_OrdinateCheck);
                YCo_ordinate = Convert.ToInt32(YCo_OrdinateCheck);



                while ((XCo_ordinate < 218 || XCo_ordinate > 676) && (YCo_ordinate < 186 || YCo_ordinate > 552))
                {
                    MessageBox.Show("Co_ordinates for Obstacle " + (i + 1) + " are out of bounds! Re-enter.");
                    XCo_ordinate = Convert.ToInt32(Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate X:", "Valid co-ordinate: 218 - 676"));
                    YCo_ordinate = Convert.ToInt32(Interaction.InputBox("Obstacle: " + (i + 1), "Co-ordinate Y:", "Valid co-ordinate: 186 - 552"));


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

            Thread shooter_1 = new Thread(delegate ()
            {

                int Temp = Co_OrdinatesShoot[1];

                ShootYOne = Co_OrdinatesShoot[1];

                for (int i = 0; i < shooter_one_count; i++)
                {
                    ShootYOne = ShootYOne - 3;
                    ShootOne();
                    Thread.Sleep(100);
                
               

                    if (i == shooter_one_count - 1)
                    {
                        ShootYOne = Temp;
                        i = 0;
                    }
                }

               

            });

            Thread shooter_2 = new Thread(delegate ()
            {

                int Temp2 = Co_OrdinatesShoot[3];

                ShootYTwo = Co_OrdinatesShoot[3];
                for (int i = 0; i < shooter_two_count; i++)
                {
                    ShootYTwo = ShootYTwo - 3;
                    ShootTwo();
                    Thread.Sleep(200);

                    if (i == shooter_two_count - 1)
                    {
                        ShootYTwo = Temp2;
                        i = 0;
                    }
                }

                if (picShoot1.Location.X == picPlaneMap.Location.X)
                {
                    pBarLifePlane.Value = pBarLifePlane.Value - 10;
                }

            });

            Thread shooter_3 = new Thread(delegate ()
            {

                int Temp3 = Co_OrdinatesShoot[5];

                ShootYThree = Co_OrdinatesShoot[5];
                for (int i = 0; i < shooter_three_count; i++)
                {
                    ShootYThree = ShootYThree - 3;
                    ShootThree();
                    Thread.Sleep(100);

                    if (i == shooter_three_count - 1)
                    {
                        ShootYThree = Temp3;
                        i = 0;
                    }

                }
            });

            Thread shooter_4 = new Thread(delegate ()
            {

                int Temp4 = Co_OrdinatesShoot[7];
                ShootYFour = Co_OrdinatesShoot[7];

                for (int i = 0; i < shooter_four_count; i++)
                {
                    ShootYFour = ShootYFour - 3;
                    ShootFour();
                    Thread.Sleep(10);

                    if (i == shooter_four_count - 1)
                    {
                        ShootYFour = Temp4;
                        i = 0;
                    }
                }
            });

            Thread shooter_5 = new Thread(delegate ()
            {
                int Temp5 = Co_OrdinatesShoot[9];
                ShootYFive = Co_OrdinatesShoot[9];
                for (int i = 0; i < shooter_five_count; i++)
                {
                    ShootYFive = ShootYFive - 3;
                    ShootFive();
                    Thread.Sleep(1000);

                    if (i == shooter_five_count - 1)
                    {
                        ShootYFive = Temp5;
                        i = 0;
                    }
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
            tabPlane.SelectedTab = tabInventoryCheck;




        }

        private void timeShoot1_Tick(object sender, EventArgs e)
        {



        }


        int MovePlaneInitial;
        int MovePlaneEnd;
        bool Done = false;

        int FuelDown = 0;

        Thread planeMove = null;

        int IncreasingSeconds, IncreasingTimeMinutes= 0;

        public void Seconds()
        {
            if (this.lblTimeBegun.InvokeRequired)
            {
                MovePlane moving = new MovePlane(Seconds);
                this.Invoke(moving);
            }
            else
            {
                this.lblTimeBegun.Text = IncreasingTimeMinutes.ToString() + ":" + IncreasingSeconds.ToString();
            }
        }
        
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            
            Thread increasingTime = new Thread(delegate()
            {
                while (picPlaneMap.Location.X < 780)
                {
                    IncreasingSeconds = IncreasingSeconds + 1;

                    if (IncreasingSeconds == 60)
                    {
                        IncreasingSeconds = 0;
                        IncreasingTimeMinutes = IncreasingTimeMinutes + 1;
                    }

                    Seconds();
                    Thread.Sleep(100);
                }
                
            });

            increasingTime.Start();

            FuelDown = Convert.ToInt32(txtFuelLeft.Text);
            int InventoryWeight = InventoryCheck.Count();
            Thread FuelLeft = new Thread(delegate ()
            {
                while (FuelDown != 0)
                {
                    FuelDown = FuelDown - 1;
                    FuelDying();
                    Thread.Sleep((10 * speedChange) - InventoryWeight);
                }

                if (FuelDown == 0)
                {
                    MessageBox.Show("You have failed! Fuel tank depleted!");
                  //  lstDescription.Items.Add("Success Rating: " + (100 - pBarEnemy.Value) + "%");
                    
                }

            });

            FuelLeft.Start();
            txtFuelLeft.Enabled = false;

            

            speedChange = Convert.ToInt32(numudSpeed.Value);
            speedPlane = picPlaneMap.Location.X;

           // timePlaneMove.Interval = 1000;
           // timePlaneMove.Start();

            if (picPlaneMap.Location.X > 800)
            {
                timePlaneMove.Stop();
            }



               Thread speedGoing = new Thread(delegate ()
               {
                   while (speedPlane != 0)
                   {
                       speedPlane = speedPlane - 3;
                       PlaneSpeed();

                      


                       
                       Thread.Sleep(100);

                      

                   }

                   while (speedPlane != 769)
                   {
                       speedPlane = speedPlane + 3;


                       PlaneSpeed();
                       Thread.Sleep(100 * speedChange);
                       speedChange = Convert.ToInt32(numudSpeed.Value);


                   }
               });

               speedGoing.Start(); 

            btnSimulate.Enabled = false;



        }

        public void FuelDying()
        {
            if (this.txtFuelLeft.InvokeRequired)
            {
                MovePlane moving = new MovePlane(FuelDying);
                this.Invoke(moving);
            }
            else
            {
                this.txtFuelLeft.Text = FuelDown.ToString();
            }

        }

        public delegate void MovePlane();

        public void movingPlane()
        {
            if (this.picPlaneMap.InvokeRequired)
            {
                MovePlane moving = new MovePlane(movingPlane);
                this.Invoke(moving);
            }
            else
            {
                this.picPlaneMap.Location = new Point(MovePlaneInitial, picPlaneMap.Location.Y);
            }
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
                this.picShoot1.Location = new Point(Co_OrdinatesShoot[0], ShootYOne);
                if (picShoot1.Location.Y == picPlaneMap.Location.Y && picShoot1.Location.X == picPlaneMap.Location.X)
                {
                    pBarLifePlane.Value = pBarLifePlane.Value - 10;
                }
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
                if (picShoot2.Location.Y == picPlaneMap.Location.Y && picShoot2.Location.X == picPlaneMap.Location.X)
                {
                    pBarLifePlane.Value = pBarLifePlane.Value - 10;
                }
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
                if (picShoot3.Location.Y == picPlaneMap.Location.Y && picShoot3.Location.X == picPlaneMap.Location.X)
                {
                    pBarLifePlane.Value = pBarLifePlane.Value - 10;
                }
            }
        }

        int speedPlane, speedChange = 0;
        Thread speedGoing = null;

        private void btnAlter_Click(object sender, EventArgs e)
        {
            

        }

        public void PlaneSpeed()
        {
            if (this.picPlaneMap.InvokeRequired)
            {
                MovePlane moving = new MovePlane(PlaneSpeed);
                this.Invoke(moving);
            }
            else
            {
                if (picPlaneMap.Location.X - picShoot1.Location.X < 10 || picPlaneMap.Location.X - picShoot1.Location.X < 10)
                {
                    this.picPlaneMap.Location = new Point(speedPlane, picPlaneMap.Location.Y - 10);
                    this.picPlaneMap.Location = new Point(speedPlane, picPlaneMap.Location.Y + 10);

                }
                else
                {
                    this.picPlaneMap.Location = new Point(speedPlane, picPlaneMap.Location.Y);

                    if (speedPlane < 278)
                    {
                        lblArmory.Visible = true;
                        picArmory.Visible = true;

                        lblBaracks.Visible = true;
                        picBarracks.Visible = true;

                        lblQuarters.Visible = true;
                        picOffice.Visible = true;

                        lblMessHall.Visible = true;
                        picMessHall.Visible = true;

                        lblHospital.Visible = true;
                        picHostpital.Visible = true;
                    }

                }

                int Shoot1 = picPlaneMap.Location.Y;

              

            }

        }

        private void tabPlane_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        int alitudePlaneUp, altitudePlaneDown = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            alitudePlaneUp = picPlaneMap.Location.Y;

            int alterAltitude = Convert.ToInt32(numudAltitude.Value);

            Thread Altitude = new Thread(delegate ()
            {

                alitudePlaneUp = alitudePlaneUp - (alterAltitude * 3);
                PlaneAltitudeUp();

                Thread.Sleep(1000);
            });

            Altitude.Start();
        }

        public void PlaneAltitudeUp()
        {
            if (this.picPlaneMap.InvokeRequired)
            {
                MovePlane moving = new MovePlane(PlaneAltitudeUp);
                this.Invoke(moving);
            }
            else
            {
                this.picPlaneMap.Location = new Point(picPlaneMap.Location.X, alitudePlaneUp);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            altitudePlaneDown = picPlaneMap.Location.Y;

            int alterAltitude = Convert.ToInt32(numudAltitude.Value);

            Thread Altitude = new Thread(delegate ()
            {

                altitudePlaneDown = altitudePlaneDown + (alterAltitude * 3);
                PlaneAltitudeDown();

                Thread.Sleep(1000);
            });

            Altitude.Start();
        }

        List<string> InventoryCheck = new List<string>();
        int ExtraWeight = 0;
        int CountInventory = 0;

        private void btnInventory_Click(object sender, EventArgs e)
        {
            int NumberOfBombs = Convert.ToInt32(numOfBombs.Value);

            for (int i = 0; i < NumberOfBombs; i++)
            {
                InventoryCheck.Add("Bomb: " + i);
            }

            ExtraWeight = 5000 * NumberOfBombs;
            lblExtraWeight.Text = "TOTAL EXTRA WEIGHT: " + ExtraWeight.ToString() + "KG";

            lblInventoryLeft.Text = "INVENTORY LEFT: " + NumberOfBombs;
        }

        private void picMessHall_Click(object sender, EventArgs e)
        {
            if (InventoryCheck.Count() != 0)
            {
                InventoryCheck.RemoveAt(InventoryCheck.Count() - 1);
                pBarEnemy.Value = pBarEnemy.Value - 5;
                picMessHall.Enabled = false;
                lblInventoryLeft.Text = "INVENTORY LEFT: " + (InventoryCheck.Count());

            }
            else
            {
                MessageBox.Show("NO MORE AMO!");
            }

        }

        private void picArmory_Click(object sender, EventArgs e)
        {
            if (InventoryCheck.Count() != 0)
            {
                InventoryCheck.RemoveAt(InventoryCheck.Count() - 1);
                pBarEnemy.Value = pBarEnemy.Value - 30;
                picArmory.Enabled = false;
                lblInventoryLeft.Text = "INVENTORY LEFT: " + (InventoryCheck.Count());

            }
            else
            {
                MessageBox.Show("NO MORE AMO!");
            }

        }

        private void picPostOffice_Click(object sender, EventArgs e)
        {
            if (InventoryCheck.Count() != 0)
            {
                InventoryCheck.RemoveAt(InventoryCheck.Count() - 1);
                pBarEnemy.Value = pBarEnemy.Value - 10;
                picPostOffice.Enabled = false;
                lblInventoryLeft.Text = "INVENTORY LEFT: " + (InventoryCheck.Count());
            }
            else
            {
                MessageBox.Show("NO MORE AMO!");
            }

        }

        private void picHostpital_Click(object sender, EventArgs e)
        {
            if (InventoryCheck.Count() != 0)
            {
                InventoryCheck.RemoveAt(InventoryCheck.Count() -1 );
                pBarEnemy.Value = pBarEnemy.Value - 15;
                picHostpital.Enabled = false;
                lblInventoryLeft.Text = "INVENTORY LEFT: " + (InventoryCheck.Count());
            }
            else
            {
                MessageBox.Show("NO MORE AMO!");
            }

        }

        private void picBarracks_Click(object sender, EventArgs e)
        {
            if (InventoryCheck.Count() != 0)
            {
                InventoryCheck.RemoveAt(InventoryCheck.Count() - 1);
                    pBarEnemy.Value = pBarEnemy.Value - 20;
                picBarracks.Enabled = false;
                lblInventoryLeft.Text = "INVENTORY LEFT: " + (InventoryCheck.Count());
                
            }
            else
            {
                MessageBox.Show("NO MORE AMO!");
            }
           
            
        }

        private void picOffice_Click(object sender, EventArgs e)
        {
            if (InventoryCheck.Count() != 0)
            {
                InventoryCheck.RemoveAt(InventoryCheck.Count() - 1);
                pBarEnemy.Value = pBarEnemy.Value - 20;
                picOffice.Visible = false;
                lblInventoryLeft.Text = "INVENTORY LEFT: " + (InventoryCheck.Count());

            }
            else
            {
                MessageBox.Show("NO MORE AMO!");
            }

        }

        private void btnProceedInventory_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabPlaneSpecs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabSimulate;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabObstacles;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabObstacles;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabInventoryCheck;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabPlane.SelectedTab = tabPlaneSpecs;
        }

        private void timePlaneMoving_Tick(object sender, EventArgs e)
        {
            
        }

        public void PlaneAltitudeDown()
        {
            if (this.picPlaneMap.InvokeRequired)
            {
                MovePlane moving = new MovePlane(PlaneAltitudeDown);
                this.Invoke(moving);
            }
            else
            {
                this.picPlaneMap.Location = new Point(picPlaneMap.Location.X, altitudePlaneDown);
               
            }
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
                if (picShoot4.Location.Y == picPlaneMap.Location.Y && picShoot4.Location.X == picPlaneMap.Location.X)
                {
                    pBarLifePlane.Value = pBarLifePlane.Value - 10;
                }
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
                if (picShoot5.Location.Y == picPlaneMap.Location.Y && picShoot5.Location.X == picPlaneMap.Location.X)
                {
                    pBarLifePlane.Value = pBarLifePlane.Value - 10;
                }
            }
        }

    }
}
