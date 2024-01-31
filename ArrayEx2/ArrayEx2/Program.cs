using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int additionOfEvens = 0;
            for(int i = 0; i < 8; i++)
            {
                Console.Write("Enter number :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 1; i < 8; i++)
            {
                if (arr[i] %2 == 0)
                {
                    additionOfEvens = additionOfEvens + arr[i];
                }
            }

            Console.Write("Addition of evens are :" + additionOfEvens);
        }
    }
}
