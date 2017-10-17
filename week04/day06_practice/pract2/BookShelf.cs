using System;
using System.Collections.Generic;

namespace pract2
{
    public class BookShelf
    {
        public List<Book>bookList = new List<Book>();

        public void BookAdder(Book book)
        {
            bookList.Add(book);
        }

        public void BookRemover(Book book)
        {
            bookList.Remove(book);
        }

        public void EarliestPublish()
        {
            int year = 2000;
            foreach (var book in bookList)
            {
                if (book.releaseYear < year)
                {
                    year = book.releaseYear;
                }
            }
            Console.WriteLine("the earliest book on the shelf was: " + year);
        }

        public void LatestPublish()
        {
            int year = 1000;
            foreach (var book in bookList)
            {
                if (book.releaseYear > year)
                {
                    year = book.releaseYear;
                }
            }
            Console.WriteLine("the latest publish on the shelf was: " + year);
        }

        public void WhatsOnTheShelf()
        {
            Console.WriteLine("these books are on the self:");
            foreach (var book in bookList)
            {
                Console.WriteLine("Author: " + book.author + " Title: " + book.title + " Release year: " + book.releaseYear);
            }
        }
    }
}