using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Lesson.Models
{
    internal class Library
    {
        public string Name { get; set; }
        private Book[] Books { get; set; }
        public Library(int size)//[23,1]
        {
            Books= new Book[size];
        }
        public Book this[int index]
        {
            get
            {
                if (index>=0&&index<Books.Length)
                    return Books[index];
                throw new IndexOutOfRangeException();

            }
            set
            {
                if (index >= 0 && index < Books.Length)
                    Books[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }

        }
    }
}
