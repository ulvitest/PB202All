using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension.Lesson.Models
{
    internal class Student:IComparable
    {
        public  int Id { get; set; }
        public static int _id;
        public  string Name { get; set; }
        public int[] Points { get; set; }

        static Student()
        {
            Console.WriteLine("static ctor work");
            //    _id++;
            //    Id = _id;//1
        }

        public  void Info()
        {
            Console.WriteLine($"Name: {Name} Id: {Id}");
        }
        public override string ToString()
        {
            return $"Name: {Name} Id: {Id}";
        }

        public int CompareTo(object? stu)
        {
            var student= stu as Student;
            return Name.CompareTo(student.Name);//110,20
        }
    }
}
