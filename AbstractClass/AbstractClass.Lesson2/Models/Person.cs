using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Models
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract string Info();

        public virtual string Detail()
        {
            return "person detail";
        }
    }
}
