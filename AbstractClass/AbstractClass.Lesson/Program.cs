using AbstractClass.Lesson.Models;

namespace AbstractClass.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Person person  =new Person();
            //Student student = new(1, "Ziya", "Musayev", 100);
            ////student.Info();
            //Console.WriteLine(student);

            //Worker worker = new(2, "Test", "Testov", "Programing");
            //Console.WriteLine(worker);
            //worker.Info();

            //polymorphism
            //override (dynmaic) runtime
            //method overloading,operator overloading (static) compile
            //Student[] students = { student, new(2, "Test", "", 20) };
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            //object[] numbers = { student,worker,1,"",true,'a'};

            //Person person = new(12, "", "");
            //abstract=>class,method(property),method
            //access modifers:
            //non access modifiers:partial,abstract,static,sealed
            //DesignStudent designStudent = new DesignStudent();
            //designStudent.Id=20;
            //designStudent.Name = "Test";
            //designStudent.SurName = "lorem";
            //designStudent.Point = 20;
            //designStudent.Info();
            //designStudent.GetInfo();
            #endregion
            /*
             4.Parameter olaraq integer array variable-i ve 
            bir integer value qebul eden ve hemin integer value-nu integer array-e
            yeni element kimi elave eden metod. Misal üçün int[] nums = {1,5,7} deyə 
            bir variable-mız var.yazdığımız metodu çağırıb arqument olaraq nums və 3 
            göndərsək nums arrayının dəyəri  {1,5,7,3} olmalıdır.
             */
            int[] nums = { 1, 5, 7 };//01
           
            foreach (var item in AddElementToArray( nums, 3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

        }
        
        static int[] AddElementToArray( int[]arr1,int a)
        {
            //arr1 =02
            int[]arr2= new int[arr1.Length+1];//
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            arr2[arr2.Length-1] = a;

            arr1 = arr2;
            return arr1;


        }

    }
}
