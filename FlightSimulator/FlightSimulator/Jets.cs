using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class Jets
    {
        private int jetID;

        public int JetID
        {
            get { return jetID; }
            set { jetID = value; }
        }

        private string jetName;

        public string JetName
        {
            get { return jetName; }
            set { jetName = value; }
        }


        private double jetSpeed;

        public double JetSpeed
        {
            get { return jetSpeed; }
            set { jetSpeed = value; }
        }

        private double jetFuel;

        public double JetFuel
        {
            get { return jetFuel; }
            set { jetFuel = value; }
        }

        private double jetAltitude;

        public double JetAltitude
        {
            get { return jetAltitude; }
            set { jetAltitude = value; }
        }

        private double jetWeight;

        public double JetWeight
        {
            get { return jetWeight; }
            set { jetWeight = value; }
        }


        public Jets(int jetid, string jetname, double jetfuel, double jetspeed, double jetweight, double jetaltitude)
        {
            this.jetID = jetid;
            this.JetName = jetname;
            this.JetFuel = jetfuel;
            this.jetSpeed = jetspeed;
            this.jetWeight = jetweight;
            this.jetAltitude = jetaltitude;
        }
    }

}