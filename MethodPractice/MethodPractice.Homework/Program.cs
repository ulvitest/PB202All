namespace MethodPractice.Homework
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1.Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 
            //string word = " salam sagol lorem";
            //Console.WriteLine(RemoveEmptySpace(word));
            //5.Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
            //Console.WriteLine(FindA("salam sagol"));

        }

        public static string RemoveEmptySpace(string s)
        {
            string newWord = string.Empty;//""
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]!=' ')
                    newWord += s[i];
                
            }
            return newWord;

        }
        public static bool FindA(string word)//salam
        {
            bool isExist=false;
            foreach (char item in word)
            {
                if (item=='a')
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }
        public static int FindACount(string word)//salam
        {
            int count = 0;  
            foreach (char item in word)
            {
                if (item == 'a')
                    count++;
            }
            return count;
           
        }
        public static string Print(string s)
        {
         string result= s switch
            {
                "programiong" => "Case 1",
                "design" => "Case 2",
                "sytem" => "Case 3",
                _=> "Case 4",
            };
            return result;
        }

    }

}
