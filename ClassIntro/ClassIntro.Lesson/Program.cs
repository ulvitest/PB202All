using System.Net.Http.Headers;
using System.Text;

namespace ClassIntro.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first
            //string name = "Alizamin";
            //string address = "Baki";
            //int age = 19;
            //string phone = "";

            //string name2 = "Filankes";
            //string address2 = "Baki";
            //int age2 = 19;
            //string phone2 = "";
            //var student1 = new
            //{
            //   name="Alizamin",
            //   address="Baki",
            //   phone="",
            //   age=12
            //};
            //Console.WriteLine(student1.age);
            //var student2 = new
            //{
            //    name = "",
            //    address = "Baki"

            //};
            //Console.WriteLine(student2.age);

            //Student stu1 = new Student();//instance
            //stu1.Name = "Alizamin";
            //stu1.Age = 20;
            //stu1.Surname = "Agazade";
            //stu1.Address = "Baki";
            ////Console.WriteLine(stu1.Info());

            //Student stu2 = new Student();
            //stu2.Name = "Test";
            //stu2.Age = 20;
            //stu2.Surname = "Testov";
            //stu2.Address = "Baki";
            ////Console.WriteLine(stu2.Info());

            //Student stu3 = new Student()
            //{
            //    Name = "Filankes",
            //    Age = 20,
            //    Surname = "Test",
            //    Address = "Baki"
            //};
            //Console.WriteLine(stu3.FullInfo());
            ////stu3.Info();

            //StringHelper stringHelper = new StringHelper();
            //Console.WriteLine(stringHelper.ReverseStr("lorem"));
            #endregion
            #region second

            //constructor
            //1.class ile eyni adli olur
            //2.instance alanda ishleyir
            //3.return type-i olmur;

            //Student stu4 = new Student();
            //stu4.Name= "Test";
            //stu4.Age = 20;
            //stu4.Surname = "Testov";
            //stu4.Address = "Baki";
            //stu4.Info();

            Worker worker = new Worker();
            worker.Name = "test";
            worker.Surname = "testov";
            worker.Address = "Baki";
            worker.Age = 20;
            worker.Profession = "dev";
            Console.WriteLine(worker.Info());
            Console.WriteLine(worker.FullInfo());
















            #endregion
        }



    }
    
   


}
