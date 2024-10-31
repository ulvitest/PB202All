using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Interfaces
{
    interface IA
    {
        void Sum();
    }
    interface IB
    {
        void Sum();

    }
    internal class A : IA, IB
    {
        void IA.Sum()
        {
            throw new NotImplementedException();
        }

        void IB.Sum()
        {
            throw new NotImplementedException();
        }
    }

}
