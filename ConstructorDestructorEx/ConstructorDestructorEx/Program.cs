using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorEx
{
    class Book
    {
        private int bookId;
        private string bookName;

        public Book(int bid, string bname)
        {
            this.bookId = bid;
            this.bookName = bname;
        }

        public void displayBook()
        {
            Console.WriteLine("Book Id :" + bookId);
            Console.WriteLine("Book Name :" + bookName);
        }

        ~Book()
        {
            Console.WriteLine("Object Deleted !");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(1,"C#");
            b.displayBook();
        }
    }
}
