using System;
using System.Collections.Generic;

namespace pract2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            Book book1 = new Book("Douglas Adams", "The Hitchhiker's Guide to the Galaxy", 1979);
            Book book2 = new Book("Frank Herbert", "Dune", 1965);
            Book book3 = new Book("Frank Herbert", "The Dragon in the Sea", 1957);
            Book book4 = new Book("Douglas Adams", "Mostly Harmless", 1992);
            
            bookShelf.BookAdder(book1);
            bookShelf.BookAdder(book2);
            bookShelf.BookAdder(book3);
            bookShelf.BookAdder(book4);
            
            bookShelf.BookRemover(book4);
            bookShelf.EarliestPublish();
            bookShelf.LatestPublish();
            bookShelf.WhatsOnTheShelf();

            Console.WriteLine();
        }
    }
}