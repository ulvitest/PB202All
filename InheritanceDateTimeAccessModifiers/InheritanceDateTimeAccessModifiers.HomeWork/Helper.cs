using System.Text;

namespace InheritanceDateTimeAccessModifiers.HomeWork
{
    class Helper
    {
        public string ReverseStr(string str)//Salam necesen=>malaS nesecen
        {
            string[] massive=str.Split(' ');//[salam,necesen]
            StringBuilder stringBuilder=new StringBuilder();
            for (int i = 0; i < massive.Length; i++)
            {
                string word=massive[i];
                for (int j = word.Length-1; j >= 0; j--)
                {
                   stringBuilder.Append(word[j]);
                }
                stringBuilder.Append(' ');
            }
            return stringBuilder.ToString();
        }
    }
}
