using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro.Lesson
{
    class StringHelper
    {
        //Verilmiş stringi tərsinə yazdırın.

        public string ReverseStr(string str) //lorem
        {
            StringBuilder stringBuilder = new StringBuilder();//instance
            for (int i = str.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(str[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
