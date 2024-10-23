namespace MethodPractice.NewLesson
{
    internal class Program
    {

        //method
        static void Main(string[] args)
        {
            string word = "";
            //method signature:
            //1.methodun adi
            //2.methodun parametrlerini sayi
            //3.methodun parametrlerin data type-i
            //Sum();
            CrudStudent();


        }

        #region methodFirst
        //public static void MakeSalam()
        //{
        //    Console.WriteLine("salam");
        //}
        ////filankes salam deyir
        //public static void MakeSalamSecond(string name)
        //{
        //    Console.WriteLine(name+ " "+"salam deyir");
        //}
        //public static int Sum(int a,int b)
        //{
        //    return a + b;
        //}
        //public static string GetFullName(string name,string surname)
        //{
        //    return name + " "+surname;
        //}
        //public static int SumOrSub(int num1,int num2 )//10,12
        //{
        //    if (num1 > num2)
        //        return num1- num2;
        //    return num1+ num2;
        //}
        //public static bool CheckNumber(int n, int m)//parametr
        //{
        //    return n > m;//6,7

        //}

        //public static int[] MakeArray()
        //{
        // return new int[] { 1, 2, 3 };
        //}
        #endregion
        #region default

        //public static int Sum(int x)
        //{
        //    return x ;
        //}

        //public static int SumArray(params int[] array)
        //{
        //    int sum = 0;
        //    foreach (var item in array) 
        //       sum+= item;
        //    return sum;
        //}
        //public static int Test(params int[] arr)//{20,1,10.56}
        //{
        //    int count = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item > 20 && item < 60)
        //            count++;
        //    }
        //    return count;
        //}

        #endregion
        #region methodOverloading
      
        //public static int Sum()
        //{
        //    return 0;
        //}

        //public static void Sum(params int[] arr)
        //{

        //}
        //public static int Sum(int a=5)
        //{
        //    return a;
        //}
      

        #endregion

        public static string Print(string name)
        {
            return name;
        }
        public static string Print(string name,string surname)
        {
            return Print(name) +" "+surname;
        }
        public static string Print(string name, string surname,int age)
        {
            return Print(name,surname)+ " "+age;
        }


        public static void CrudStudent()
        {
            ShowMenu();

            Console.WriteLine("student deleted");
        }
        public static void ShowMenu()
        {
            Console.WriteLine("choose one operation");
            Console.WriteLine("1.add student");
            Console.WriteLine("2.Remove student");
            Console.WriteLine("3.Find Student");

        }

    }


}
