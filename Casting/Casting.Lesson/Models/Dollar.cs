using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Lesson.Models
{
    internal class Dollar
    {
        public Dollar(double usd)
        {
            Usd = usd;
        }

        public double Usd { get; set; }
    }
}
