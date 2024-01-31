using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoopsEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int physics, chemistry, maths, bio, english, total;
            double percentage;

            Console.Write("Enter the marks for physics subject :");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks for chemistry subject :");
            chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks for maths subject :");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks for bio subject :");
            bio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks for english subject :");
            english = Convert.ToInt32(Console.ReadLine());

            total = physics + chemistry + maths + bio + english;
            percentage = (double) total / 5;
            Console.WriteLine("Total :"+total);
            Console.WriteLine("Percentage :" + percentage);

            if (percentage >= 70)
            {
                Console.WriteLine("Distinction Class");
            }
            else {
                if (percentage >= 60)
                {
                    Console.WriteLine("First Class");
                }
                else {
                    if (percentage >= 50)
                    {
                        Console.WriteLine("Second Class");
                    }
                    else {
                        if (percentage >= 40)
                        {
                            Console.WriteLine("Pass");
                        }
                        else {
                            Console.WriteLine("Fail");
                        }
                    }
                }
            }
        }
    }
}
