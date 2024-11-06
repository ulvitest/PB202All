using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Lesson.Models
{
    internal class DesignEngineer:Engineer
    {
        public string Tool { get; set; }

        public override void Detail()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Tool:{Tool}");
        }
        public override bool Equals(object? obj)
        {
           if(obj is DesignEngineer d)
            {
                return Name.Equals(d.Name);
            }
           return false;
            
        }
    }
}
