using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input 3*3 matrix  and display it.
            int[,] arr = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("Enter number :");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
