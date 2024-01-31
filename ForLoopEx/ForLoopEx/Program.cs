using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for(int i = 10; i <= 30; i++)
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
