using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the numerb :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
