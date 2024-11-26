namespace ThreadTaskExample
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Thread thread1 = new Thread(account.Increase);
            Thread thread2 = new Thread(account.Decrease);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();


            //racecondition
            //lock 
            //deadlock
            //task
            //async
            //await
            //threadpool

            Console.WriteLine(account.Count);

        }

        //static void Loop1()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        //Thread.Sleep(1000);
        //        Console.WriteLine("loop1 "+i);
        //    }
        //}
        //static void Loop2()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        //Thread.Sleep(1000);
        //        Console.WriteLine("loop2 "+i);
        //    }
        //}
    }
}
