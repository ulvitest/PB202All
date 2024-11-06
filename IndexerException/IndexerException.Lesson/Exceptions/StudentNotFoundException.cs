using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Lesson.Exceptions
{
    internal class StudentNotFoundException:Exception
    {
        public StudentNotFoundException()
        {
            
        }
        public StudentNotFoundException(string mes):base(mes)
        {
            
        }
        public StudentNotFoundException(string mes,Exception inner) : base(mes,inner)
        {

        }
    }
}
