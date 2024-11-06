using Casting.Generics.Models;
using Casting.Generics.Service;
using System.Collections;

namespace Casting.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");

            //MyIntList myIntList = new MyIntList();
            //myIntList.Add(20);
            //myIntList.Add(2);
            //myIntList.ShowAll();

            //MyStrList myStrList = new MyStrList();
            //myStrList.Add("lorem");
            //myStrList.Add("ipsum");
            //myStrList.ShowAll();

            //MyStuList myStuList = new MyStuList();
            //myStuList.Add(new() { Name = "Filankes" });
            //myStuList.ShowAll();

            MyList<int,Object> myIntList = new MyList<int>();
            myIntList.Add(20);
            myIntList.Add(10);

            MyList<string,Object> myStrList = new MyList<string>();
            myStrList.Add("");

            MyList<Student,Test> myStuList = new MyList<Student>();
            myStuList.Add(new Student(""));


            //generic constraints

           


        }
    }
}
