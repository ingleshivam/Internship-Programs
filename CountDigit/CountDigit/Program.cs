using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number :");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 10 && number <= 99)
            {
                Console.WriteLine("The number is two digit number");
            }
            else {
                Console.WriteLine("The number is not two digit number");
            }
        }
    }
}
