using System;
using System.Collections.Generic;

namespace AllOfCSharp
{
    struct Book
    {
        private string title;
        private string author;
        private string publications;
        private UInt64 isbn;
        
        public void SetValues(string title, string author, string publications, UInt64 isbn)
        {
            this.title = title;
            this.author = author;
            this.publications = publications;
            this.isbn = isbn;
        }

        public void DisplayValues()
        {
            Console.WriteLine("Title = " + title);
            Console.WriteLine("Author = " + author);
            Console.WriteLine("Publications = " + publications);
            Console.WriteLine("ISBN = " + isbn);
        }
    }

    class StructureDemo
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.SetValues("C programming", "E Balagurusamy", "Mc Graw Hill", 9845671250);
            book1.DisplayValues();
            Console.ReadLine();
        }
    }
}
