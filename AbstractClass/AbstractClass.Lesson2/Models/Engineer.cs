using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Models
{
    internal abstract  class Engineer:Person
    {
        public string[]Knowledges { get; set; }

        public abstract void GetEngineerExperience();

    }
}
