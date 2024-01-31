using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayObjectEx1
{

    internal class Book
    {
        private int bookId;
        private string bookName;
        private string authorName;
        private double price;

        public void addBook(int bid,string bname, string aname, double p)
        {
            this.bookId = bid;
            this.bookName = bname;
            this.authorName = aname;
            this.price = p;
        }

        public void displayBook()
        {
            if (price > 2000)
            {
                Console.WriteLine("Book Id :" + this.bookId);
                Console.WriteLine("Book Name :" + this.bookName);
                Console.WriteLine("Author Name :" + this.authorName);
                Console.WriteLine("Book Price :" + this.price);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book [] b = new Book[5];

            int id;
            double price;
            string bname, aname;
            
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter Book Id :");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Book Name :");
                bname = Console.ReadLine();

                Console.Write("Enter Author Name :");
                aname = Console.ReadLine();

                Console.Write("Enter Price : ");
                price = Convert.ToDouble(Console.ReadLine());

                b[i] = new Book();
                b[i].addBook(id, bname, aname, price);
            }
            Console.WriteLine("#################### Output ####################");
            
            for(int i = 0; i < 5; i++)
            {                    
                    b[i].displayBook();           
            }
        }
    }
}

