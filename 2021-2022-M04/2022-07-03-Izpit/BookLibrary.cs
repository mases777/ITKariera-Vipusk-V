using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public class BookLibrary
    {
        private string name;
        private List<Book> books;

        public BookLibrary(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }

        public void AddBook(string title, double rating)
        {
            Book book = new Book(title, rating);
            books.Add(book);
        }

        public double AverageRating()
        {
            return books.Average(x => x.Rating);
        }

        public List<string> GetBooksByRating(double rating)
        {
            return books.Where(x => x.Rating > rating).Select(x => x.Title).ToList();
        }

        public List<Book> SortByTitle()
        {
            books = books.OrderBy(x => x.Title).ToList();
            return books;
        }

        public List<Book> SortByRating()
        {
            books = books.OrderByDescending(x => x.Rating).ToList();
            return books;
        }

        public string[] ProvideInformationAboutAllBooks()
        {
            return books.Select(x => x.ToString()).ToArray();
        }

        public bool CheckBookIsInBookLibrary(string title)
        {
            foreach (Book book in books)
                if (book.Title == title)
                    return true;
            return false;
        }
    }
}