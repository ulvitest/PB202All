using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson.Models
{
    internal class Worker:Person 
    {
        public Worker(int id,string name,string surname,string profession):base(id,name,surname)
        {
            Profession = profession;
        }

        public string Profession { get; set; }

        public override void Detail()
        {
            Console.WriteLine("worker detail");
        }

        public override void Info()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Surname:{SurName} Prof:{Profession}");
        }

        public override string ToString()
        {
            return Profession;
        }
    }
}
