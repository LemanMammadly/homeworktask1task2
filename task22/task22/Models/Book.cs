using System;
using System.Collections.Generic;
using System.Text;

namespace task22.Models
{
    internal class Book
    {
        public string Name;
        public string Author;
        public int PageCount;
        public string Genre;

        public Book(string name, string author, int pageCount,string genre)
        {
            Name = name;
            Author = author;
            PageCount = pageCount;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Name}\n{Author}\n{PageCount}\n{Genre}";
        }
    }
}
