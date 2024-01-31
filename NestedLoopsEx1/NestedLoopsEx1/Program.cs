using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopsEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter the fist number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Grater number is A :" + a);
            }
            else {
                if (b > c)
                {
                    Console.WriteLine("Greate number is B :" + b);
                }
                else {
                    Console.WriteLine("Greater number is C:" + c);
                }
            }

        }
    }
}
