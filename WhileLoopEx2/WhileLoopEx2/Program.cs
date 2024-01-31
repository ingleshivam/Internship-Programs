using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,sum = 0;
            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                int dig = num % 10;
                if (dig % 2 != 0)
                {
                    sum = sum + dig;
                }
                num = num / 10;
            }

            Console.WriteLine("Sum of odd numbers  : " + sum);
        }
    }
}
