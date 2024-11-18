

namespace AbstractClass.Lesson.Models
{
    internal abstract class Person
    {
        public Person()
        {
            
        }
        public Person(int ıd, string name, string surName)
        {
            Id = ıd;
            Name = name;
            SurName = surName;
        }
      

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public virtual void Info()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Surname:{SurName}");
        }
        public abstract void Detail();


    }
}
