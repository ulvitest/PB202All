using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Interfaces
{
    internal interface IWork
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    class Worker : IWork,IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWork
    {

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
