using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Output is :");

            for(int i = 0; i < 5; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}
