using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Models
{
    internal class Book
    {
        static int count = 0;
        public int _id;
        public string Name { get; set; }
        public string Author { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        


        public Book(string name,string author)
        { 
            count++;
            _id = count;
            Name = name;
            Author = author;
        }
    }
}
