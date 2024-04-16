using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Models
{
    internal class Library
    {
        Book[] _books=new Book[0];


        public Book this[int id]
        {
            get
            {
                foreach (Book book in _books)
                {
                   if(book.Id==id)
                    {
                        return book;
                    }
                }
                return null;
            }
        }


        public void AddBook(Book book)
        {
            Array.Resize(ref _books,_books.Length+1);
            _books[_books.Length-1] = book;
        }
    }
}
