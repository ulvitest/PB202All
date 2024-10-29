using System.Reflection;

namespace InheritanceDateTimeAccessModifiers.Leson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first
            ////class members=>field,method
            //Bus bus = new Bus("TestModel","TestBrand",20);
            //bus.Info();


            //Tractor tractor = new Tractor("TesttractorModel","TestTractorBrand",200);
            //tractor.Info();

            ////Tractor tractor1 = new Tractor();

            //Library library = new Library();
            //library.Name = "Test";
            //library.Capacity = 200;
            //library.CreatedDate = DateTime.Now;

            //Book book = new Book() { Name = "", Genre = "", PageCount = 10 };

            //library.Books = new Book[] 
            //{

            //   book,
            //   new Book(){},
            //   new Book(){},
            //   new Book(){},
            //   new Book(){}
            //};

            //Human human = new Human();
            #endregion


            #region second

            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime.Year);
            //Console.WriteLine(dateTime.Month);
            //Console.WriteLine(dateTime.Day);
            //Console.WriteLine(dateTime.DayOfWeek);
            //Console.WriteLine(dateTime.Hour);
            //Console.WriteLine(dateTime.Minute);
            //Console.WriteLine(dateTime.Second);
            //Console.WriteLine(dateTime.Microsecond);
            //Console.WriteLine(dateTime.DayOfYear);


            //DateTime dateTime12 = DateTime.UtcNow;
            //Console.WriteLine(dateTime12);

            //DateTime dateTime13 = new DateTime(2024,11,29,12,06,30,700);
            //Console.WriteLine(dateTime13.AddDays(20));
            //Console.WriteLine(dateTime13.AddYears(2));

            //DateTime dateTime14 = new DateTime(2024, 11, 29, 12, 16, 30, 700);
            //DateTime dateTime15 = new DateTime(2024, 12, 29, 11, 06, 10, 600);
            //TimeSpan result=dateTime15-dateTime14;
            //Console.WriteLine(result.Days);
            //Console.WriteLine(result.Hours);
            //Console.WriteLine(result.TotalDays);
            //TimeSpan timeSpan = new TimeSpan(1,2,3);
            //TimeSpan timeSpan2 = TimeSpan.FromMinutes(20);

            //Console.WriteLine("salam");

            //Thread.Sleep(timeSpan);

            //Console.WriteLine("Sagol");

            //DateTime dateTime14 = new DateTime(2024, 11, 29, 12, 16, 30, 700);
            //Console.WriteLine(dateTime14.ToString("MM/dd/yyyy"));
            //Console.WriteLine(dateTime14.ToString("dddd, dd MMMM yyyy"));

            #endregion

            //access modifiers
            //(public,private,protected,internal,
            //private protected,protected internal)

            //class=>public,internal default=>internal
            //all class members=>default-u private-dir;

            //public=>class,all class members(field,method,property)

            //class oz daxilinde,inheritance,instance;
            //Car car = new Car();
            //car.Model = "";

            //private=>all class members(field,method,property)
            //all class members=>default-u private-dir;
            //private=>yalniz class daxilinde

            //Car car = new Car();
            //car.Model = "";
            //Console.WriteLine(car.Model);
            //typeof(Car).GetField("Model", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car, "aaa");
            //Console.WriteLine(typeof(Car).GetField("Model", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(car));


            //














        }
    }
}
