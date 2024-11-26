using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTaskExample
{
    internal class BankAccount
    {
        public int Count { get; set; }
        object lock1 = new object();
        object lock2 = new object();


        public void Increase()
        {
            for (int i = 0; i < 10000; i++)
            {
               lock(lock1)
                {
                    lock (lock2)
                    {
                        Count++;
                    }
                }
               
            }
        }
        public void Decrease()
        {
            for (int i = 0; i < 10000; i++)
            {
                lock (lock2)
                {
                    lock (lock1)
                    {
                        Count--;
                    }
                }
            }
        }
    }
}
