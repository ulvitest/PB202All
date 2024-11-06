using IndexerException.Lesson.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Lesson.Services
{
    internal class Account
    {
        public static void Login(string username, string password,Roles role)
        {
            if (string.IsNullOrWhiteSpace(username)||string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("not empty");
                return;
            }
            if (username == "_lorem" && password == "123456_")
            {
                if (role!=Roles.Admin)
                {
                    Console.WriteLine("permission denied..");
                }
                else
                {
                    Console.WriteLine("girish ugurludur");
                }
            }
            else
            {
                Console.WriteLine("pass or user invalid...");
            }
            
        }
    }
}
