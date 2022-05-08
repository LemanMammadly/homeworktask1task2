using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Models
{
    internal class Book
    {
        #region Task1
        private static int _count;
        public string Code;
        public string Name;
        public string AuthorName;
        public int PageCount;

        static Book()
        {
            _count = 0;
        }
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{Name.Substring(0, 2).ToUpper()}{_count}";
            _count++;
        }

        public override string ToString()
        {
            return $"{Name} {AuthorName} {PageCount} {Code}";
        }
        #endregion

    }
}
