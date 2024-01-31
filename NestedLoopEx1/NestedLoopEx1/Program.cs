using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the amstrong number form 1 to 500
            int num, sum = 0, dig;
            for (int i = 1; i <= 500; i++)
            {
                num = i;
                while (num > 0)
                {
                    dig = num%10;
                    sum = sum + (dig * dig * dig);
                    num = num / 10;
                }
                if (i == sum)
                {
                    Console.WriteLine(i + " is a amstrong number");
                }
                sum = 0;
            }
        }
    }
}
