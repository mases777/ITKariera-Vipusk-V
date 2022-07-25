using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private Book next;

        public Book Next
        {
            get { return next; }
            set { next = value; }
        }

        public Book(string bookId)
        {
            this.BookId = bookId;
            this.Next = null;
        }

        public override string ToString()
        {
            return $"Book: {this.BookId}";
        }
    }
}
