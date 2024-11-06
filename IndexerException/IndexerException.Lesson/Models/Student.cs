

namespace IndexerException.Lesson.Models
{
    internal class Student
    {
        public Student(int id, string name, int point)
        {
            Id = id;
            Name = name;
            Point = point;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }

        public override string ToString()
        {
            return Id+" "+Name+" "+Point;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Student)
            {
                Student student = (Student)obj;
                return Name.Equals(student.Name);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (Name + Id).GetHashCode();
        }

        public static bool operator >=(Student a, Student b)
        {
            return a.Name.Length >= b.Name.Length;
        }
        public static bool operator <=(Student a, Student b)
        {
            return a.Name.Length <=b.Name.Length;
        }


    }
}
