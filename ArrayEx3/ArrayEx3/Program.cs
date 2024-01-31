using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input 10 numbers and find maximum number
            int[] arr = new int[10];
            int max = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Enter number :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 1; i < 10; i++)
            {
                if (arr[i-1] > arr[i])
                {
                    max = arr[i - 1];
                }
                else
                {
                    max = arr[i];
                }
            }
            Console.Write("Maximum number in array is :" + max);
        }
    }
}
