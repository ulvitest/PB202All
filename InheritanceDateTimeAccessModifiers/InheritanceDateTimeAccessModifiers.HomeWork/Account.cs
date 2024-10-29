namespace InheritanceDateTimeAccessModifiers.HomeWork
{
    class Account //"" " "
    {
        public void Login(string password,string userName)//lorem123 ve password 123456* 
        {
            if (string.IsNullOrWhiteSpace(password)||string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("username or password empty"); 
                return;
            }
            if (password== "123456*"&&userName=="lorem123")
            {
                Console.WriteLine("ugurludur");
            }
            else
            {
                Console.WriteLine("pass ve ya userName sehfvdir..");
            }
        }
    }
}
