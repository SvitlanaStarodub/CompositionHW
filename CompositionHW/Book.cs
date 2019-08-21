using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionHW
{
    public class Book
    {
        private string _bookName;
        private string _text;
        private Author _author;

        public Book(string bookName, string context, string authorName, string authorSurname)
        {
            _bookName = bookName;
            _text = context;
            _author = new Author(authorName, authorSurname);
        }

        public string BookName
        {
            get { return _bookName; }
            private set { _bookName = value; }
        }

        public string Text
        {
            get { return _text; }
        }

        public override string ToString()
        {
            string book = _author + " " + _bookName;
            return book;
        }

    }
}
