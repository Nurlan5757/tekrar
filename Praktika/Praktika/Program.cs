using Praktika.Models;

namespace Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("asd", "abd");
            Book book2 = new Book("abs", "adb");

            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book2);

            Book book3 = library[1];
            Console.WriteLine(book3.Name+" "+book3.Author);


        }
    }
}
