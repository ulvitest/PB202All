using Microsoft.EntityFrameworkCore;
using OrmPractice.Lesson.Data;
using OrmPractice.Lesson.Models;

namespace OrmPractice.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //orm
            #region linq
            //List<int> numbers = new List<int>() { 23, 44, 11, 6, 120,33 };
            //numbers.FindAll(n => n > 10);
            //numbers.Where(x => x > 10).ToList();
            //numbers.Sum(x => x);
            //numbers.Average(x => x);
            //numbers.Min(x => x);
            //numbers.OrderBy(x => x).Skip(2).Take(2);//23,33
            //numbers.OrderDescending();
            //foreach (var item in numbers.Select(x => x>30).ToList())
            //{
            //    Console.WriteLine(item);
            //}
            //var result = from s in numbers
            //             where s>10
            //             orderby s
            //             select s;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(numbers.FirstOrDefault(x => x > 1));
            //Console.WriteLine(numbers.First(x => x > 1));
            //Console.WriteLine(numbers.SingleOrDefault(x=>x==22));
            //Console.WriteLine(numbers.Single(x=>x==22));
            #endregion
            //string connectionStr = "Server=DESKTOP-14DGEFO\\SQLEXPRESS;Database=PB202;Trusted_Connection=True";
            Add();
            //GetAll();
            //GetById(2);
            //AddRange();
            //Delete(2);
            //Update(2);
            //code first,db first
        }
        static void Add()
        {
            
            AcademyDbContext academyDbContext = new AcademyDbContext();
            Group group = new() { No = "pb204" };
            var result = academyDbContext.Entry(group);

            academyDbContext.Groups.Add(group);

            //added
            academyDbContext.SaveChanges();
        }
        static void AddRange()
        {
            List<Group>list=new List<Group>();
            list.Add(new() { No = "pb205" });
            list.Add(new() { No = "pb206" });
            AcademyDbContext academyDbContext = new AcademyDbContext();
            academyDbContext.Groups.AddRange(list);
            academyDbContext.SaveChanges();
        }
        static void GetAll()
        {
            AcademyDbContext academyDbContext = new AcademyDbContext();
           var groupList= academyDbContext.Groups.ToList();
            foreach (var item in groupList)
                Console.WriteLine(item);
        }
        static void GetById(int id)
        {
            AcademyDbContext academyDbContext = new AcademyDbContext();
            //var group = academyDbContext.Groups.Find(id);
            //var group = academyDbContext.Groups.First(g=>g.Id>111);
            //var group = academyDbContext.Groups.FirstOrDefault(g=>g.Id>1);
            //var group = academyDbContext.Groups.SingleOrDefault(g=>g.Id==1);
            var group = academyDbContext.Groups.Single(g=>g.Id==1);
            Console.WriteLine(group);
        }
        static void Delete(int id)
        {
          
           AcademyDbContext academyDbContext = new AcademyDbContext();
            var existGroup = academyDbContext.Groups.SingleOrDefault(g => g.Id == id);
            if (existGroup!=null)
            {
                academyDbContext.Groups.Remove(existGroup);
                //deleted
                academyDbContext.SaveChanges();
            }
            else Console.WriteLine("not found");
        }
        static void Update(int id)
        {
            AcademyDbContext academyDbContext = new AcademyDbContext();
            var existGroup = academyDbContext.Groups.SingleOrDefault(g => g.Id == id);
            
            if (existGroup != null)
            {
                existGroup.No = "Pb120";
                //modified
                academyDbContext.SaveChanges();
            }
            else Console.WriteLine("not found");
        }
    }
}
