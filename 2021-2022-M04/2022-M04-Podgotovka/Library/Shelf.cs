using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Shelf
    {
        Book head;
        Book tail;
        private int count;

        public int Count
        {
            get { return count; }
            
        }
        public void AddBook(string bookId)
        {
            if (head == null)
            {
                head = new Book(bookId);
                tail = head;
            }
            else
            {
                Book node = new Book(bookId);
                tail.Next = node;
                tail = node;
            }
            count++;
        }

        public void AddSpecialBook(string bookId)
        {
            Book temp = head;
            head = new Book(bookId);
            head.Next = temp;
            count++;
        }

        public Book CheckBookIsPresent(string bookId)
        {
            Book temp = head;
            if (head == null)
            {
                return null;
            }
            for (int i = 0; i < count; i++)
            {
                if (temp.BookId == bookId)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }

        public bool ReleaseBook(string bookId)
        {
            Book temp = head;
            if (head.BookId == bookId)
            {
                head = head.Next;
                count--;
                return true;
            }
            while (temp != null)
            {
                if (temp.Next == null)
                {
                    return false;
                }
                if (temp.Next.BookId == bookId)
                {
                    if (temp.Next == tail)
                    {
                        tail = temp;
                    }
                    temp.Next = temp.Next.Next;
                    count--;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public bool ReleaseBook(int index)
        {
            Book temp = head;
            if (index > count || index < 0)
            {
                return false;
            }
            if (index == 0)
            {
                head = head.Next;
                count--;
                return true;
            }
            for (int i = 0; i < index; i++)
            {
                if (i == index - 1)
                {
                    temp.Next = temp.Next.Next;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();
            if (count == 0)
            {
                sb.AppendLine("Shelf is empty!");
            }
            else
            {
                Book temp = head;
                while (temp != null)
                {
                    sb.AppendLine(temp.ToString());
                    temp = temp.Next;
                }
            }
            return sb;
        }

    }


    //class Shelf
    //{
    //    private List<Book> Books;
    //    public Shelf()
    //    {
    //        Books = new List<Book>();
    //    }

    //    public int Count
    //    {
    //        get
    //        {
    //            return Books.Count;
    //        }
    //    }
    //    public Book Head
    //    {
    //        get
    //        {
    //            return Books.Min();
    //        }
    //    }
    //    public Book Tail
    //    {
    //        get
    //        {
    //            return Books.Max();
    //        }
    //    }

    //    public void AddBook(string bookId)
    //    {
    //        var book = new Book(bookId);
    //        Books.Add(book);
    //    }

    //    public void AddSpecialBook(string bookId)
    //    {
    //        Books.Insert(0, new Book(bookId));
    //    }

    //    public Book CheckBookIsPresent(string bookId)
    //    {
    //        return Books.Where(x => x.BookId == bookId).FirstOrDefault();
    //    }

    //    public bool ReleaseBook(string bookId)
    //    {
    //        var book = Books.Where(x => x.BookId == bookId).FirstOrDefault();
    //        return Books.Remove(book);
    //    }

    //    public bool ReleaseBook(int index)
    //    {

    //        if (index >= 0 && index < Books.Count)
    //        {
    //            Books.RemoveAt(index);
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }

    //    public StringBuilder ShelfInformation()
    //    {
    //        var stb = new StringBuilder();
    //        if (Books.Count > 0)
    //        {
    //            for (int i = 0; i < Books.Count; i++)
    //            {
    //                stb.AppendLine(Books[i].ToString());
    //            }
    //            return stb;
    //        }
    //        else
    //        {
    //            stb.AppendLine("Shelf is empty!");
    //            return stb;
    //        }
    //    }
    //}


    //class Shelf
    //{
    //    private Book head;
    //    private Book tail;
    //    private int count;
    //    public Shelf()
    //    {
    //        this.head = null;
    //        this.tail = null;
    //        this.count = 0;
    //    }
    //    public int Count
    //    {
    //        get { return count; }
    //        set { count = value; }
    //    }
    //    public void AddBook(string bookId)
    //    {
    //        if (this.head == null)
    //        {
    //            var next = new Book(bookId);
    //            this.head = next;
    //            this.tail = next;
    //        }
    //        else
    //        {
    //            var next = new Book(bookId);
    //            this.tail.Next = next;
    //            tail = next;
    //        }
    //        this.Count++;
    //    }
    //    public void AddSpecialBook(string bookId)
    //    {
    //        if (this.head == null)
    //        {
    //            var next = new Book(bookId);
    //            this.head = next;
    //            this.tail = next;
    //        }
    //        else
    //        {
    //            var next = new Book(bookId);
    //            next.Next = this.head;
    //            this.head = next;
    //        }
    //        this.Count++;
    //    }
    //    public Book CheckBookIsPresent(string bookId)
    //    {
    //        var current = head;
    //        while (current != null)
    //        {
    //            if (current.BookId == bookId)
    //            {
    //                return current;
    //            }
    //            current = current.Next;
    //        }
    //        return null;
    //    }
    //    public bool ReleaseBook(string bookId)
    //    {
    //        var current = head;
    //        Book previous = null;
    //        int index = 0;
    //        while (current != null)
    //        {
    //            if (current.BookId == bookId)
    //            {
    //                return ReleaseBook(index);
    //            }
    //            index++;
    //            previous = current;
    //            current = current.Next;
    //        }
    //        return false;
    //    }
    //    public bool ReleaseBook(int index)
    //    {
    //        var current = head;
    //        Book previous = null;
    //        int i = 0;
    //        while (current != null)
    //        {
    //            if (index == 0 && index == i)
    //            {
    //                var name = this.head.BookId;
    //                this.head = this.head.Next;
    //                count--;
    //                return true;
    //            }
    //            if (index == i)
    //            {
    //                var name = current.BookId;
    //                previous.Next = current.Next;
    //                count--;
    //                return true;
    //            }
    //            i++;
    //            previous = current;
    //            current = current.Next;
    //        }
    //        return false;
    //    }
    //    public StringBuilder ShelfInformation()
    //    {
    //        StringBuilder result = new StringBuilder();
    //        var current = head;
    //        while (current != null)
    //        {
    //            result.Append(current + "\n");
    //            current = current.Next;
    //        }
    //        if (result == null)
    //        {
    //            result.Append("<Shelf is empty!>");
    //        }
    //        return result;
    //    }
    //}



}
