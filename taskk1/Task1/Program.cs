using ConsoleApp9.Models;
using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Library library = new Library();

            library.Books.Add(new Book("Anna Karenina", "Leo Tolstoy", 300));
            library.Books.Add(new Book("Lolita", "Vladimir Nabokov", 200));
            library.Books.Add(new Book("Hamlet", "William Shakespeare", 500));
            library.Books.Add(new Book("The Great Gatsby", "Scott Fizgerald", 600));
            library.Books.Add(new Book("Middlemarch", "George Eliot", 100));

            foreach (Book book in library.Books)
            {
                Console.WriteLine(book);
            }
            #endregion
        }
    }
}
