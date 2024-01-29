using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1,r=4;
            for(int i = 1; i <= r; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(num+" ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
