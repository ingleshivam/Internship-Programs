using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number :");
            number = Convert.ToInt32(Console.ReadLine());
            int CalculateSquare = number * number;
            Console.WriteLine("Square of a number is : " + CalculateSquare);
        }
    }
}
