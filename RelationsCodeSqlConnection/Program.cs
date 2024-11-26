using RelationsCodeSqlConnection.Services;
using System.Data.SqlClient;

namespace RelationsCodeSqlConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //ADO NET,ORM(ENTITY FRAMEWORK)
            //string connectionString = "Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB202;Trusted_Connection=true";
            StudentService studentService = new();
            //studentService.Create(new() { Name = "Sebnem", Age = 20 });
            //studentService.Update(1, new() { Name = "Fatime", Age = 22 });
            //studentService.Delete(3);
            //Console.WriteLine(studentService.GetById(2));
            //foreach (var stu in studentService.GetAll())
            //    Console.WriteLine(stu);
            //Console.WriteLine(studentService.GetStudentsAgeAvg());
            //Console.WriteLine(studentService.GetStudentsCount());
            studentService.GetStudentsByAge();
        }
    }
}
