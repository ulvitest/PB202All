using Casting.Lesson.Models;

namespace Casting.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region first
            ProgramerEngineer progEngineer = new ProgramerEngineer();
            //Console.WriteLine(progEngineer.GetType());
            progEngineer.Id = 1;
            progEngineer.Name = "Samid";
            progEngineer.Language = "c#";
            //progEngineer.Detail();

            DesignEngineer designEngineer = new DesignEngineer();
            //Console.WriteLine(designEngineer.GetType());
            designEngineer.Id = 2;
            designEngineer.Name = "Leman";
            designEngineer.Tool = "PhotoShop";
            //designEngineer.Detail();

            //boxing,implicit,upcasting

            //Person[] person = {designEngineer, progEngineer };
            //Person p1 = new DesignEngineer();

            //unboxing,explicit,downcasting

            //foreach (var item in person)
            //{
            //    //if (item is DesignEngineer d)
            //    // {
            //    //     //DesignEngineer designEngineer1 = (DesignEngineer)item;
            //    //     d.Detail();
            //    // }
            //    DesignEngineer d = item as DesignEngineer;
            //    if (d!=null)
            //    {
            //        d.Detail();
            //    }


            //}
            //int num = 12;
            //double d = num;
            //double d = 12.3;
            //int num = (int)d;

            //int day = 1;
            //switch (day)
            //{
            //    case (int)weekday.monday:
            //        break;
            //    default:
            //}
            #endregion

            //implicit,explicit operators
            Manat manat = new(340);
            Dollar dollar = manat;//200
            Console.WriteLine(dollar.Usd);


        }
    }
}
