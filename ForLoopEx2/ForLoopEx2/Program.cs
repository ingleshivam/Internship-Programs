using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddCount = 0;
            for(int i = 10; i <= 40; i++)
            {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                    oddCount++;
                }
            }
            Console.WriteLine("OddCount : " + oddCount);
        }
    }
}
