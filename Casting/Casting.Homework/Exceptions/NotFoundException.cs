using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Homework.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException()
        {

        }
        public NotFoundException(string ms) : base(ms)
        {

        }
        public NotFoundException(string ms, Exception ex) : base(ms, ex)
        {

        }
    }
}
