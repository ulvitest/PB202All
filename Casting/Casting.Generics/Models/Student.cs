using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Generics.Models
{
    internal class Student:BaseEntity
    {
        public Student(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(Student? other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
