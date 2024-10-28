using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassIntro.Lesson
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Address;
        public string Info()
        {
            return $"Name: {Name} Surname: {Surname}";
        }
        public string FullInfo()
        {
            return $"{Info()} Age: {Age}";
        }
    }
}
