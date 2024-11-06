using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Homework.Models
{
    internal class Person:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public static Person[] GetAllPerson()
        {
            Person p1 = new() { Name = "Lorem", Age = 20 };
            Person p2 = new() { Name = "Lorem11", Age = 2 };
            Person p3 = new() { Name = "Lorem20", Age = 30 };
            Person p4 = new() { Name = "Lorem5", Age = 25 };
            return new Person[] { p1, p2, p3, p4 };
        }

        public int CompareTo(object? obj)
        {
            if (obj is null || obj is not Person)
                throw new Exception();
            Person p = obj as Person;
            return Age.CompareTo(p.Age);
        }
        public override string ToString()
        {
            return Age.ToString();
        }
        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }
}
