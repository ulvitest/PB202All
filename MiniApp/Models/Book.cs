using MiniApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniApp.Models
{
    internal class Book : IEntity
    {
        static int _id;
        public Book()
        {
            
        }

        public Book(string name, string authorName, int pageCount)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDelete { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name}");
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
