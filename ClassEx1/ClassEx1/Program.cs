using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx1
{
    //Class Book
    internal class Book {
        private int bookId;
        private string bookName;
        private string authorName;
        private int price;

        public void addBook(int bid,string bname, string aname, int p)
        {
            bookId = bid;
            bookName = bname;
            authorName = aname;
            price = p;  
        }

        public void displayBook()
        {
            Console.WriteLine("Book Id : " + bookId);
            Console.WriteLine("Book Name :" + bookName);
            Console.WriteLine("Author Name :" + authorName);
            Console.WriteLine("Prie :" + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.addBook(1, "C#", "ABC", 200);
            b1.displayBook();

            Book b2 = new Book();
            b2.addBook(2, "VB", "XYZ", 300);
            b2.displayBook();
        }
    }
}
