using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension.Lesson.Extensions
{
    internal  static partial class Extension
    {
        public static int Pow(this int value)
        {
            return value * value;
        }
    }
}
