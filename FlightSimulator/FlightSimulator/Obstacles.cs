using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class Obstacles
    {
        private int obstacleID;

        public int ObstacleID
        {
            get { return obstacleID; }
            set { obstacleID = value; }
        }

        private int coordinatesY;

        public int CoordinatesY
        {
            get { return coordinatesY; }
            set { coordinatesY = value; }
        }


        private int coordinatesX;

        public int CoordinatesX
        {
            get { return coordinatesX; }
            set { coordinatesX = value; }
        }


        public Obstacles(int coordinatesY, int coordinatesX)
        {
            this.coordinatesX = coordinatesX;
            this.coordinatesY = coordinatesY;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", coordinatesY, coordinatesX);
        }

        

    }
}
