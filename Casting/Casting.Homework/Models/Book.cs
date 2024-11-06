using Casting.Homework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Homework.Models
{
    internal class Book : Product
    {
        public Book(int pageCount, string authorName,string name,double price,int count)
        {
            PageCount = pageCount;
            AuthorName = authorName;
            Name = name;
            Price = price;
            Count= count;
        }

        public int PageCount { get; set; }
        public string AuthorName { get; set; }
        public override void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalInCome += Price;
                return;

            }
            throw new ProductCountIsZeroException();
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Count:{Count}");
        }
    }
}
