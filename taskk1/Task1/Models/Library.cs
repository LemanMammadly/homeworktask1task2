using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Models
{
    internal class Library
    {
        #region Task1
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> books = Books.FindAll(b => b.Name.ToLower() == name.ToLower());

            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            return books;
        }


        public void RemoveAllBookByNama(string name)
        {
            Books.RemoveAll(b => b.Name.ToLower() == name.ToLower());
        }
        public List<Book> SearchBooks(string value)
        {
            List<Book> books = Books.FindAll(b => b.Name.ToLower() == value.ToLower() || b.AuthorName.ToLower() == value.ToLower() || b.PageCount.ToString() == value);
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            return books;
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> books = Books.FindAll(b => b.PageCount < max && b.PageCount > min);
            return books;
        }

        public void RemoveByNo(string value)
        {
            Books.RemoveAll(b => b.Code.ToLower() == value.ToLower());
        }
    }
    #endregion
}

