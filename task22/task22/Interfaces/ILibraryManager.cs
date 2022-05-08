using System;
using System.Collections.Generic;
using System.Text;
using task22.Models;

namespace task22.Interfaces
{
    interface ILibraryManager
    {
        public List<Book> Books { get; set; }

        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string value);
        List<Book> Filter(string value,string value1);
    }
}
