using MiniApp.Models;
using MiniApp.Services;

namespace MiniApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                LibraryManager libraryManager = new LibraryManager();

                Book book = new("Book1", "Author1", 100);

                libraryManager.AddBook(book);
                libraryManager.AddBook(new("Book2", "Author2", 110));
                libraryManager.AddBook(new("Book3", "Author3", 200));
                libraryManager.AddBook(new("Book4", "Author3", 200));

                //Console.WriteLine(libraryManager.GetBookById(1));
                //libraryManager.DeleteBookById(2);
                //libraryManager.EditBookById(3, "loremm");
                foreach (var item in libraryManager.FilterByPageCount(50, 150))
                {
                    Console.WriteLine(item);
                }
            }
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
