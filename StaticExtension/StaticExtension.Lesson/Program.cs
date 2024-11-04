using StaticExtension.Lesson.Extensions;
using StaticExtension.Lesson.Models;

namespace StaticExtension.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static 
            //class,class members(field,method,property),ctor
            //Console.WriteLine(Student.Id);
            //Console.WriteLine(Student.Name);
            //Student.Info();

            //Student student1 = new Student();//0
            ////Console.WriteLine("static Id"+" "+Student._id);//1
            //Console.WriteLine("Id"+" "+student1.Id);

            //Console.WriteLine("===================");

            //Student student2 = new Student();
            ////Console.WriteLine("static Id"+ " " + Student._id);//2
            //Console.WriteLine("Id"+ " " + student2.Id);

            //Console.WriteLine("=====================");
            //Student student3 = new Student();
            ////Console.WriteLine("static Id" + " " + Student._id);//3
            //Console.WriteLine("Id" + " " + student3.Id);

            //Student student4 = new Student();
            ////Console.WriteLine("static Id" + " " + Student._id);//4
            //Console.WriteLine("Id" + " " + student4.Id);

            //Student._id = 1;

            //Student student = new Student();
            //Student.Name = "";

            //Console.WriteLine(Test.Age);

            //string word = "lorem";
            //word.GetFirstLetter();

            //string word2 = "Ipsum";
            //word2.GetFirstLetter();

            //int num = 12;
            //num.Pow();

            //string word = "1Lorem";
            //Console.WriteLine(word.HasDigit("[A-Z]"));

            //Student student = new Student();
            //student.Points =new int[]{ 22,70,100};
            //student.GetPointAwg();

            int[] numbers = { 11, 1, 23 };
            //Array.Sort(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            Student[] students = {
                new() { Id = 20 },
                new() { Id = 1 }, 
                new() { Id = 30 } 
            };
            Array.Sort(students);
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

        }
       
        
    }
}
