using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaticExtension.Lesson.Extensions
{
    internal  static partial class Extension
    {
        public static char GetFirstLetter(this string w)
        {
            return w[0];
        }
        public static bool HasDigit(this string w,string pattern)//lorem
        {
            Regex regex = new(pattern);
            return regex.IsMatch(w);
            //foreach (var item in w)
            //{
            //    if (char.IsDigit(item))
            //        return true;
            //}
            //return false;
            //FullName => Filankes Lorem
        }
    }
}
