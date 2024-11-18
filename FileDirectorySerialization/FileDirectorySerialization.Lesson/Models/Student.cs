using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileDirectorySerialization.Lesson.Models
{
    //[Serializable]
    public class Student
    {
        private int Id;
        public string Name { get; set; }
        public int Age { get; set; }
        public Student()
        {
            
        }

        public Student(int ıd, string name, int age)
        {
            Id = ıd;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
        public void Test(int num)
        {
            Console.WriteLine(num);
        }
    }
}
