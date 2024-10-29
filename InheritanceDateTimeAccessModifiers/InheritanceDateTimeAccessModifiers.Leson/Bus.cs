using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDateTimeAccessModifiers.Leson
{
    internal class Bus:Car
    {
        //fields
        public int PassengerCount;
       

        public Bus(string model, string brand, int passengerCount):base(model,brand)
        {
            PassengerCount = passengerCount;
            
        }

      
    }
}
