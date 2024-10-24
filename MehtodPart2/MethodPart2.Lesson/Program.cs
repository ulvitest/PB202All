using System.Globalization;
using System.Text;

namespace MethodPart2.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region stringMethod
            //string word1 = "lorem ipse um";
            //Console.WriteLine(word1.Length);
            //string w=word1.ToUpper();
            //Console.WriteLine(word1.ToLower());
            //Console.WriteLine(word1.ToLowerInvariant());
            //CultureInfo culture = new CultureInfo("AZ");
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine(word1.ToUpper(culture));
            //Console.WriteLine(word1.ToUpperInvariant());
            //Console.WriteLine(word1.Trim());
            //Console.WriteLine(word1.TrimStart());
            //Console.WriteLine(word1.TrimEnd());
            //Console.WriteLine(word1.StartsWith(' '));
            //Console.WriteLine(word1.EndsWith(' '));
            //Console.WriteLine(word1.Replace('l','a'));
            //Console.WriteLine(word1.Replace("ulvi","l"));
            //Console.WriteLine(word1.Equals("abc"));
            //Console.WriteLine(string.Compare("az", "y"));
            //Console.WriteLine(word1.Contains('a',StringComparison.OrdinalIgnoreCase));
            //var result= word1.Split(' ');
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //string[]words=new string[] { "lorem","ipsum" };
            //Console.WriteLine(string.Join(",", words));
            //bool isExist=false;
            //int num = 12;
            //Console.WriteLine(isExist.ToString());
            //Console.WriteLine(num.ToString());

            //string name = "Filankes";
            //string surname = "Filankesov";
            //string word = $"Name :{name} Surname: {surname}";
            //string.Format("Name :{0} Surname : {}", name, surname);
            //Console.WriteLine(string.Concat("aa", "bb", "cc"));
            //Console.WriteLine("aa"+"bb"+"cc");
            //string word = "lAoraemulviipasumA";
            ////Console.WriteLine(word.Substring(2,5));
            //Console.WriteLine(word.IndexOf('a',StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(word.LastIndexOf('a'));
            //Console.WriteLine(word.Substring(word.IndexOf('u'),4));
            #endregion
            #region array
            int[] numbers = { 11, 2,16 };
            numbers[0] = 20;
            string[] names = new string[3];//null null null
            //Console.WriteLine(names.Length);
            //Console.WriteLine(names.Rank);
            //int[,] array = new int[2, 3] { {1,2,3 },{ 6,1,3,} };
            //Console.WriteLine(array[1,0]);
            //Console.WriteLine(array.Rank);
            //Console.WriteLine(array.Length);
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Array array = Array.CreateInstance(typeof(int), 2);//0,0
            //array.SetValue(11,0);
            //array.SetValue(14,1);
            //int[]arr=array as int[];
            //arr[0] = 33;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion







        }













        public static void ChangeNum(ref int a)
        {
        }
        public static void ChangeStr(string str)
        {
            str = "ipsum";
        }

       
        public static void ChangeArr(int[] arr)
        {
            arr[0] = 100;
        }
    }
}
