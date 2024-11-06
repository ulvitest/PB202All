using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Homework.Exceptions
{
    internal class CapacityException:Exception
    {
        public CapacityException()
        {
            
        }
        public CapacityException(string ms):base(ms)
        {
            
        }
        public CapacityException(string ms,Exception ex) : base(ms,ex)
        {

        }
    }
}
