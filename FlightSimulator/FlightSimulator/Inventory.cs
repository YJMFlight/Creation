using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class Inventory : Jets
    {
        private string invName;

        public string InvName
        {
            get { return invName; }
            set { invName = value; }
        }

        private int invAmountLeft;

        public int InvAmountLeft
        {
            get { return invAmountLeft; }
            set { invAmountLeft = value; }
        }

        public Inventory(int jetid, string jetname, double jetfuel, double jetspeed, double jetweight, double jetaltitude, string invname, int invamountleft) : base(jetid, jetname, jetfuel, jetspeed, jetweight, jetaltitude)
        {
            this.invName = invname;
            this.invAmountLeft = invamountleft;
        }
    }
}
