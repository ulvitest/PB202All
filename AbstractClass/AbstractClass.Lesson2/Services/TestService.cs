using AbstractClass.Lesson2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Services
{
    internal class TestService : IAdd,IDivide
    {
        public double Add(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Divide(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
