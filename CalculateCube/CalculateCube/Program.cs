using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number :");
            number = Convert.ToInt32(Console.ReadLine());
            int CalculateCube;
            CalculateCube = number * number * number;
            Console.WriteLine("The cube of a given number is :" + CalculateCube);
        }
    }
}
