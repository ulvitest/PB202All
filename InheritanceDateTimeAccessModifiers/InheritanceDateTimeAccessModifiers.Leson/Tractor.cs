using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDateTimeAccessModifiers.Leson
{
    internal class Tractor:Car
    {
        //fields
        public int Baggage;

        //public Tractor():base("","")
        //{
            
        //}
        public Tractor(string model, string brand, int baggage):base(model,brand)
        {
            Baggage = baggage;
        }
       
    }
}
