using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Lesson.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
