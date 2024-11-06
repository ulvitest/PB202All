using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Lesson.Models
{
    internal class Manat
    {
        public Manat(double azn)
        {
            Azn = azn;
        }

        public double Azn { get; set; }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn/1.7);
        }
    }
}
