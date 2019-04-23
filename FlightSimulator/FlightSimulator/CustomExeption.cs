using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class CustomExeption: Exception
    {
        public CustomExeption(string message) : base(message)
        {

        }
        public CustomExeption() : base()
        {

        }
    }
}
