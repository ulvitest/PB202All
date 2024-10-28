using System.Text;

namespace ClassIntro.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            .Repeat deyə bir method olsun və iki parametr qəbul etsin biri "word" digəri "count" yəni bu şəkildə "Repeat(string word, int count)" bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın. Məsələn:
                Repeat("Ha!") //Ha!
                Repeat("Ha!", 2) //Ha!Ha!
                Repeat("Ha!", 3) //Ha!Ha!Ha!
            */
            Repeat(" ", 2);
        }
        public static string Repeat(string word, int count)
        {
            //if (string.IsNullOrEmpty(word)) //null ""
            //    return "duzgun daxil et";
            StringBuilder stringBuilder = new StringBuilder(",");
            if (string.IsNullOrWhiteSpace(word)) //null " "
                return "duzgun daxil et";

            for (int i = 0; i < count; i++)
                stringBuilder.Append(word);
            stringBuilder.Append(',');

            return stringBuilder.ToString();
        }
    }
}
