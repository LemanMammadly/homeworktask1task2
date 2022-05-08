using System;
using System.Collections.Generic;
using System.Text;
using task22.Interfaces;
using task22.Models;

namespace task22.Servicess
{
    internal class LibraryManager: ILibraryManager
    {
        public List<Book> Books { get; set; }

        public LibraryManager()
        {
            Books = new List<Book>();
        }
        public void Add(Book book)
        {
            List<Book> books = new List<Book>();

            if (Books.Exists(b => b.Name.ToLower() == book.Name.ToLower()))
            {
                throw new Exception("SameBookalreadyAddedExpection");
            }
            else
            {
                Books.Add(book);
            }
        }

        public List<Book> Filter(string value,string value1)
        {
            List<Book> books=Books.FindAll(b=>b.Author.ToLower() == value.ToLower() || b.Genre.ToLower()==value1.ToLower());
            return books;
        }

        public List<Book> Search(string value)
        {
        
            List<Book> books = Books.FindAll(b => b.Name.ToLower() == value.ToLower() || b.Author.ToLower() == value.ToLower() || b.PageCount.ToString() == value || b.Genre.ToLower() == value.ToLower());
            return books;
        }

        public Book ShowInfo(string name)
        {
            Book book = Books.Find(b => b.Name.ToLower() == name.ToLower());
           
            if (book==null)
            {
                throw new Exception("BookNotFoundException");
            }
            else
            {
                return book;
            }
        }
    }
}
