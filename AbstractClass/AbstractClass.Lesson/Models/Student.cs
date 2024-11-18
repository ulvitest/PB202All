using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson.Models
{
    internal class Student:Person
    {
        public int Point { get; set; }
        public Student()
        {
            
        }
        public Student(int id,string name,string surname,int point):base(id,name,surname)
        {
            Point = point;
        }
        public sealed override void Info()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Surname:{SurName} Point {Point}");
        }
        public override string ToString()
        {
            return Name;
        }

        public override void Detail()
        {
            Console.WriteLine("student detail");
        }
        public void GetInfo()
        {
            Console.WriteLine("Samid");
        }
      
    }
    class DesignStudent:Student
    {
       
    }
}
