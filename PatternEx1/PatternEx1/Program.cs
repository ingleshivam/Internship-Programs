using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            for(int i = 1; i <= 6; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
