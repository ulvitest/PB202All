namespace MehtodPart2.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 10; 
            //Power(ref num);
            //Console.WriteLine(num);

            //int[] array = { 1, 2, 3, 4, 5 };//001=>0.001   | 0.001=> {1,2,3,4,5}
            //PowArr(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] arr = { 11, 2 };
            //AddToArray(ref arr,5);//{11,2,5}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] arr = { -1, 2, -4, 7 };
            //MakePositive(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            string word = " Lorem Ipsum ";
            RemoveSpace(word);
            Console.WriteLine(word);


        }
        public static string RemoveSpace(string w)// lorem ipsum
        {
            string newStr=string.Empty;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] != ' ') 
                    newStr += w[i];//l lo  lor  lore 
            }
            return newStr;

        }






        public static void MakePositive(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                    array[i] *= -1;
            }
        }






        public static void AddToArray(ref int[]array,int a)
        {
            int[]newArr= new int[array.Length+1];//11,2,0
            int index = 0;
            foreach (var num in array)
            {
                newArr[index++] = num;
            }
            newArr[newArr.Length-1] = a;

            array = newArr;
            
        }






        public static void PowArr(int[] arr)//
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }
        }

        public static int Power(ref int a)
        {
            a = a * a;
            return a;
        }
    }
}
