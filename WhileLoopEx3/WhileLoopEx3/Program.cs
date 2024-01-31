using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, reverseNumber = 0;
            Console.Write("Enter a number :");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                int dig = num % 10;
                reverseNumber = reverseNumber * 10 + dig;
                num = num / 10;
            }

            Console.WriteLine("Reverse number is :" + reverseNumber);
        }
    }
}
