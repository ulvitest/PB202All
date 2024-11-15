

using MiniApp.Models;
using MiniApp.Utils.Exceptions;

namespace MiniApp.Services
{
    internal class LibraryManager
    {
         int BookLimit { get; set; } = 4;
         List<Book> Books { get; set; }
        public LibraryManager()
        {
            Books = new();
        }

        public void AddBook(Book newBook)
        {
            if (Books.Count >= BookLimit)
                throw new CapacityLimitException("limit dolub");

            if (Books.Any(b => b.Name == newBook.Name && !b.IsDelete))
                throw new AlreadyExistsException($"{newBook.Name} adli kitab movc");
           
            Books.Add(newBook);
            Console.WriteLine($"{newBook.Name} adli kitab elave edildi..");

        }
        public Book GetBookById(int? id)//5
        {
            if (id is null)
                throw new NullReferenceException("id null ola bilmez");

            if (Books.Any(b => b.Id==id && !b.IsDelete))
            {
                var existBook = Books.Find(b => b.Id == id);
                return existBook;
            }
            throw new NotFoundException($"{id} id-li kitab tapilmadi..");
        }
        public List<Book> GetAll()
        {
            //return Books.Where(b=>!b.IsDelete).ToList();
            return Books.FindAll(b => !b.IsDelete);
        }
        public void DeleteBookById(int? id)
        {

            if (id is null)
                throw new NullReferenceException("id null ola bilmez");

            if (Books.Any(b => b.Id == id && !b.IsDelete))
            {
                var existBook = Books.Find(b => b.Id == id);
                existBook.IsDelete = true;
                return;
            }
            throw new NotFoundException($"{id} id-li kitab tapilmadi..");
        }
        public void EditBookById(int? id,string name)
        {

            if (id is null)
                throw new NullReferenceException("id null ola bilmez");

            if (Books.Any(b => b.Id == id && !b.IsDelete))
            {
                var existBook = Books.Find(b => b.Id == id);
                existBook.Name= name;
                return;
            }
            throw new NotFoundException($"{id} id-li kitab tapilmadi..");
        }
        public List<Book> FilterByPageCount(int minPageCount,int maxPageCount)
        {
            //return Books.Where(b=>!b.IsDelete).ToList();
            return Books
                .FindAll(b => !b.IsDelete&&b.PageCount>minPageCount&&b.PageCount<maxPageCount);
        }


    }
}
