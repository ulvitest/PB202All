using OrmPractice.CodeFirst.Data;

namespace OrmPractice.CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code first
            //migration file
            //dotnet ef migrations add firstMig1
            //dotnet ef migrations list
            //dotnet ef database update

            GetAll();
        }
        static void GetAll()
        {
            AcademyDbContext academyDbContext = new AcademyDbContext();
            var groups= academyDbContext.Groups.ToList();

            foreach (var item in groups)
                Console.WriteLine(item.No+" "+item.CreatedDate);
        }
    }
}
