using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(string title)
        {
            Book bookToRemove = books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                return true;
            }
            return false;
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> SearchByYear(int year)
        {
            return books.Where(book => book.Year == year).ToList();
        }

        public void SortByTitle()
        {
            books = books.OrderBy(book => book.Title).ToList();
        }

        public void SortByAuthor()
        {
            books = books.OrderBy(book => book.Author).ToList();
        }

        public void SortByYear()
        {
            books = books.OrderBy(book => book.Year).ToList();
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
