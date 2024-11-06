using Casting.Homework.Enums;
using Casting.Homework.Models;

namespace Casting.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var people = Person.GetAllPerson();
            //Array.Sort(people);
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //ExChange(Currency.Usd, 340);

            //Book book1 = new(500, "Filankes", "Lorem", 123.5,2);
            //book1.Sell();
            //book1.Sell();
            //book1.Sell();
            //book1.ShowInfo();
        }
        public static void ExChange(Enum e,double azn)
        {
            if (e is not Currency)
            {
                Console.WriteLine("duzgun enum gonder");
                return;
            }
            double result = 0;
            switch (e)
            {
                case Currency.Eur :
                    //
                    break;
                case Currency.Try:
                    //
                    break;
                case Currency.Usd:
                    //
                    break;

                default:
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
