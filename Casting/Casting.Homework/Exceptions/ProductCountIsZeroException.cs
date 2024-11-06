using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Homework.Exceptions
{
    internal class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException()
        {

        }
        public ProductCountIsZeroException(string ms) : base(ms)
        {

        }
        public ProductCountIsZeroException(string ms, Exception ex) : base(ms, ex)
        {

        }
    }
}
