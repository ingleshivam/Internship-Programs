using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 4;
            for(int i = 1; i <= r; i++)
            {
                for(int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int j = i-1; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
