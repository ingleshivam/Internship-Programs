using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.Write("Enter the first number :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number :");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("The addition of two number is : " + result);
        }
    }
}
