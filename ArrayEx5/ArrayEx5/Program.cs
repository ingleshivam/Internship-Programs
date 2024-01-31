using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Transpose Matrix
            int[,] arr1 = new int[4, 4];
            int[,] arr2 = new int[4, 4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write("Enter number :");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Original Array :");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write(" " + arr1[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    arr2[i,j]=arr1[j,i];
                }
            }

            Console.WriteLine("Transpose Matrix");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write(" " + arr2[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
