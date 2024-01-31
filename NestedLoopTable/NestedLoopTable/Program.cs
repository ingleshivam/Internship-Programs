using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to display table form 2 to 5
            int displayTable;
            for(int i = 2; i <= 5; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write(i*j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
