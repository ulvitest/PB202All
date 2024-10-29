using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDateTimeAccessModifiers.Leson
{
     public class Car
    {
        private string Model="BMW";
        public string Brand;
        public Car()
        {
        }

        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public void Info()
        {
            Console.WriteLine($"Model: {Model} Brand: {Brand}");
        }
        public void Test()
        {
        }
    }
}
