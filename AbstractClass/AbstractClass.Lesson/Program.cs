using AbstractClass.Lesson.Models;

namespace AbstractClass.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person  =new Person();
            Student student = new(1, "Ziya", "Musayev", 100);
            //student.Info();
            Console.WriteLine(student);

            Worker worker = new(2, "Test", "Testov", "Programing");
            Console.WriteLine(worker);
            //worker.Info();

            //polymorphism
            //override (dynmaic) runtime
            //method overloading,operator overloading (static) compile
            Student[] students = { student, new(2, "Test", "", 20) };
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            //object[] numbers = { student,worker,1,"",true,'a'};

            //Person person = new(12, "", "");
            //abstract=>class,method(property),method
            //access modifers:
            //non access modifiers:partial,abstract,static,sealed

        }
    }
}
