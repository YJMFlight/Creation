using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class Obstacles : Jets
    {
        private int obstacleID;

        public int ObstacleID
        {
            get { return obstacleID; }
            set { obstacleID = value; }
        }

        private double obstacleShootAltitude;

        public double ObstacleShootAltitude
        {
            get { return obstacleShootAltitude; }
            set { obstacleShootAltitude = value; }
        }

        private bool obstacleAvoided;

        public bool ObstacleAvoided
        {
            get { return obstacleAvoided; }
            set { obstacleAvoided = value; }
        }


        public Obstacles(int jetid, string jetname, double jetfuel, double jetspeed, double jetweight, double jetaltitude, int obstacleid, double obstacleshootaltitude, bool obstacleavoided) : base(jetid, jetname, jetfuel, jetspeed, jetweight, jetaltitude)
        {
            this.obstacleID = obstacleid;
            this.obstacleShootAltitude = obstacleshootaltitude;
            this.obstacleAvoided = obstacleavoided;
        }
    }
}
