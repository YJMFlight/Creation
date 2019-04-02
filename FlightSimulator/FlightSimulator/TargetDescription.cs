using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class TargetDescription : Jets
    {
        private DateTime timeOfTarget;

        public DateTime TimeOfTarget
        {
            get { return timeOfTarget; }
            set { timeOfTarget = value; }
        }

        private string nameOfTarget;

        public string NameOfTarget
        {
            get { return nameOfTarget; }
            set { nameOfTarget = value; }
        }

        private bool targetHit;

        public bool TargetHit
        {
            get { return targetHit; }
            set { targetHit = value; }
        }

        public TargetDescription(int jetid, string jetname, double jetfuel, double jetspeed, double jetweight, double jetaltitude, string targetname, bool targethit, DateTime timetarget) : base(jetid, jetname, jetfuel, jetspeed, jetweight, jetaltitude)
        {
            this.timeOfTarget = timetarget;
            this.nameOfTarget = targetname;
            this.targetHit = targethit;
        }
    }
}
