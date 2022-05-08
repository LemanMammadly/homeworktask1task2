using System;
using task22.Models;
using task22.Servicess;

namespace task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManager libraryManager = new LibraryManager();
            libraryManager.Books.Add(new Book("Anna Karenina", "Leo Tolstoy", 300, "science fiction"));
            libraryManager.Books.Add(new Book("Lolita", "Vladimir Nabokov", 200,"drama"));
            libraryManager.Books.Add(new Book("Hamlet", "William Shakespeare", 500, "detective"));
            libraryManager.Books.Add(new Book("The Great Gatsby", "Scott Fizgerald", 600, "detective"));
            libraryManager.Books.Add(new Book("Middlemarch", "George Eliot", 100,"drama"));
        }
    }
}
