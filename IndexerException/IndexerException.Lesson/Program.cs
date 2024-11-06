using IndexerException.Lesson.Enums;
using IndexerException.Lesson.Exceptions;
using IndexerException.Lesson.Models;
using IndexerException.Lesson.Services;
using IndexerException.Library;

namespace IndexerException.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first
            //Student student1 = new(1, "Nihad", 50);
            //Student student2 = new(1, "Nihad", 50);

            //Console.WriteLine(student1==student2);
            //Console.WriteLine(student1.Equals(student2));

            //Console.WriteLine(5.GetHashCode());
            //Console.WriteLine(student1.GetHashCode());
            //Console.WriteLine(student2.GetHashCode());

            //HashSet<Student> students = new HashSet<Student>();
            //students.Add(student1);
            //students.Add(student2);
            //Console.WriteLine(students.Count);

            //Student student1 = new(1, "Nihad", 50);
            //Student student2 = new(2, "Ziya", 70);
            //Console.WriteLine(student1==student2);
            #endregion

            #region second
            //int num = 12;
            //bool isExist = true;
            //ITest myStruct1 = new MyStruct();
            //myStruct1.MyProperty = 12;

            //ITest myStruct2 = myStruct1;
            //myStruct2.MyProperty = 13;
            //Console.WriteLine(myStruct1.MyProperty);


            //Console.WriteLine(myStruct2.Y);
            //myStruct2.Area();
            //myStruct2.X = 10;
            //Console.WriteLine(myStruct2.X);
            #endregion

            #region indexer
            //int[] numbers = { 1, 2, };
            //Console.WriteLine(numbers[0]);
            //List<int> numbers2 =new() { 1,2, 3 };
            //Console.WriteLine(numbers2[0]);
            //Library library = new Library(10);
            //library.Books[0] = new() { Name = "Book1" };
            //library.Books[1] = new() { Name = "Book2" };
            //library.Books[20] = new() { Name = "Book3" };
            //library[0]= new() { Name = "Book1" };
            //library[1]= new() { Name = "Book2" };
            //library[200]= new() { Name = "Book3" };

            // Console.WriteLine(library[3]);

            #endregion

            #region third
            //bug,error,exception
            //Console.WriteLine("salam");
            //Console.WriteLine(10/int.Parse("0"));
            //int result = int.Parse(Console.ReadLine());
            //int num;
            //bool result = int.TryParse(Console.ReadLine(), out num);

            //int num = 10;
            //throw new StudentNotFoundException();
            //try
            //{
            //    int[] numbers = new int[10];
            //    Console.WriteLine(numbers[10]);
            //}

            //catch (DivideByZeroException ex)
            //{

            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    //Console.WriteLine("===========");
            //}
            #endregion

            #region fourth
            //try
            //{
            //    var id = 10;
            //    GetStudentById(id);
            //}
            //catch (StudentNotFoundException  ex)
            //{

            //    throw ;
            //}
            //try
            //{
            //Calculate calculate = new();
            //calculate.Calc();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error");
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            //string name = null;
            //string result = name ?? null ?? "word";
            //Console.WriteLine(result);

            //int? num = null;
            //char? a = null;
            //GetStudentById(null);

            //int day = 2;
            //switch (day)
            //{
            //    case (int)WeekDays.Monday:
            //        break;
            //    case (int)WeekDays.Tuesday:
            //        break;
            //    default:
            //        Console.WriteLine("duzgun daxil et");
            //        break;
            //}

            //Order order = new Order();
            //order.Status =OrderStatus.Pending;

            //order.Status = OrderStatus.Accepted;

            //Task
            //username=_lorem;password=123456_;
            //Account class
            //Login method (username,password,role)
            Account.Login("_lorem", "123456_", Roles.Admin);






        }

        #region fourth
        public static Student[] GetStudents()
        {
            var stu1 = new Student(1, "Fatime1", 10);
            var stu2 = new Student(2, "Fatime2", 11);
            var stu3 = new Student(3, "Ziya", 100);
            return new Student[] { stu1, stu2, stu3 };
        }
        public static Student GetStudentById(int? id)//10
        {
            if (id == null)
                throw new NullReferenceException();
            var students = GetStudents();
            foreach (var student in students)
            {
                if (student.Id==id)
                   return student;
            }
            throw new StudentNotFoundException($"{id} id-li telebe tapilmadi");

        }

        #endregion
    }



    #region second
    //struct MyStruct : ITest
    //{
    //    public int X;
    //    public int Y { get; set; }
    //    public int MyProperty { get; set; }

    //    public MyStruct(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public void Area()
    //    {
    //        Console.WriteLine(X + Y);
    //    }


    //}
    //interface ITest
    //{
    //    public int MyProperty { get; set; }
    //}
    #endregion

}
