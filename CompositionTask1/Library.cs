using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CompositionHW
{

    public class Library 
    {
        List<Book> books = new List<Book>();
        public Library()
        {
            Book book1 = new Book("War and Peace", "text1", "Leo", "Tolstoy");
            Book book2 = new Book("Song of Solomon", "text2", "Toni", "Morrison");
            Book book3 = new Book("The Shadow of the Wind", "text3", "Carlos Ruiz", "Zafon");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
        }

        public void GetBooks()
        {
            foreach (var b in books)
            {
                Console.WriteLine(b);
            }
        }

	}
    
}
