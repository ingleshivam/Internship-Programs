using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhieLoopEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, evenCount = 0, oddCount = 0;
            Console.Write("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                int dig = num % 10;
                if (dig % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                num = num / 10;
            }

            Console.WriteLine("Even count is :" + evenCount);
            Console.WriteLine("Odd count is :" + oddCount);
        }
    }
}
