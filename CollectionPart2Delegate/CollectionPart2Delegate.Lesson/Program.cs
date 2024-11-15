using CollectionPart2Delegate.Lesson.Models;
using System.Collections;
using System.Threading.Channels;

namespace CollectionPart2Delegate.Lesson
{
    public delegate bool Check(int a);
    public delegate U Print<in T,out U>(T w);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region firstPart
            //    //Console.WriteLine("Hello, World!");
            //    //delegate,collections,record
            //    //SumEven(new int[]{ 3,4,5});
            //    //SumOdd(new int[]{ 3,4,5});
            //    //Sum(new int[]{ 3,4,5},IsOdd);
            //    //Sum(new int[]{ 3,4,5},IsEven);
            //    //Sum(new int[]{ 3,4,5},IsFive);
            //    //Sum(new int[]{ 3,4,5},delegate(int d)
            //    //{
            //    //    return d==2;
            //    //});
            //    //Sum(new int[] { 3, 4, 5 }, delegate (int d)
            //    //{
            //    //    return d == 3;
            //    //});
            //    Sum(new int[]{ 3, 4, 5 },q=>q>20);

            //    Check check = IsEven;
            //    check += IsOdd;
            //    check += IsFive;
            //    check += delegate (int a) //anonim
            //    {
            //        Console.WriteLine("delegate metyhod");
            //        return a == 2;
            //    };
            //    check += a => a > 10;
            //    //check -= IsOdd;
            //    Console.WriteLine(check.Invoke(2));

            //    //List<int> list = new List<int>();
            //    //list.FindAll(a=>a==2);
            #endregion
            #region secondPart
            //Print<string, int> print = i =>i.Length;
            //Print<string, string> print1 = t =>t;
            //Predicate,Func,Action
            //Action<int> action = (a) =>
            //{

            //};
            //Predicate<int> predicate = a => a % 2 == 1;
            //Func<int,char> func = v => v.ToString()[0] ;

            //List<Student> students = new List<Student>();
            //students.Add(new Student() { Age=10});
            //students.Add(new Student() { Age=11});
            //var newStudents= students.FindAll(s=>s.Age>10);
            //Console.WriteLine(students.Sum());
            //students.fi
            #endregion
            #region thirdPart
            //record
            //AClass aClass1 = new AClass() { Id = 1,Name="" };


            //AClass aClass2 = new AClass() { Id = 1,Name="" };
            //Console.WriteLine(aClass1==aClass2);

            //ARecord record1 = new ARecord(2,"lorem");
            //ARecord record2 = record1 with { Id=1};
            //var (Id,Name) = record2;
            #endregion

            //Stack stack = new Stack();//LIFO
            //stack.Push("lorem");
            //stack.Push(12);
            //stack.Push(false);
            ////stack.Pop();
            ////stack.Clear();
            ////stack.Contains(12);
            ////Console.WriteLine(stack.Peek());
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Queue<string> queue = new Queue<string>();//FIFO
            // queue.Enqueue("a");
            // queue.Enqueue("b");
            // queue.Enqueue("c");
            // //Console.WriteLine(queue.Peek());
            // queue.Dequeue();
            // foreach (var item in queue)
            // {
            //     Console.WriteLine(item);
            // }
            //HashSet<string> set = new HashSet<string>();
            // set.Add("a");
            // set.Add("b");
            // set.Add("ca");
            // set.Add("c");
            // //set.Remove("");
            // //set.Clear();
            // //set.RemoveWhere(s => s.Contains('ab'));

            // Console.WriteLine(set.Count);

            //SortedList sortedList = new SortedList();
            //sortedList.Add("student", "Leman");
            //sortedList.Add(20, "Filanjes");

            //SortedList<int,string> keyValuePairs = new();
            //keyValuePairs.Add(23, "Test");
            //keyValuePairs.Add(20, "lorem");
            //foreach (var item in keyValuePairs)
            //{
            //    //Console.WriteLine(item.Value);
            //}
            //Console.WriteLine(keyValuePairs[12]);

            //Dictionary<string, Student> dictionary = new();
            //dictionary.Add("stu12", new Student() { Id = 12 });
            //dictionary.Add("stu10", new Student() { Id = 10 });
            //if (!dictionary.ContainsKey("stu1"))
            //{
            //    dictionary.Add("stu1", new Student() { Id = 1 });

            //}
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(10, "lorem");
            //hashtable.Add(11, "lorem");

            List<int> list = new List<int>();   
            
           







        }
        #region secondPart
        static decimal SumAge(Student student)
        {
            decimal sum = 0;
            return sum += student.Age;

        }
        static void PrintWord(string w)
        {
            Console.WriteLine(w);
        }
        #endregion

        #region firstPart
        static void Sum(int[] arr,Func<int,bool> method)
        {
            int sum = default;
            foreach (var item in arr)
            {
                if (method(item))
                    sum += item;
            }
            Console.WriteLine(sum);
        }
        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
        static bool IsFive(int num)
        {
            return num > 5;
        }
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        #endregion


    }

    #region thirdPart
    class AClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
    record ARecord(int Id, string Name);
    #endregion
}
