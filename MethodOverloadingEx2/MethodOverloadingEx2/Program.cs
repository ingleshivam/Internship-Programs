using MethodOverloadingEx2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEx2
{
    class Shape
    {
        public void area(int radius)
        {
            double pie = 3.14;
            double caluculateAreaOfCircle = 2 * pie * radius * radius;
            Console.WriteLine("\n\t\tArea of Circle is :" + caluculateAreaOfCircle);
        }

        public void area(int length, int breadth)
        {
            int calculateAreaOfRectangle = length * breadth;
            Console.WriteLine("\n\t\tArea of Rectangle :" + calculateAreaOfRectangle+"\n");
            Console.Write("##################################################\n\n");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Console.WriteLine("############# Calculate Area of Circle #############\n");
            Console.Write("\t\tEnter Radius : ");
            int r = Convert.ToInt32(Console.ReadLine());

            s.area(r);

            Console.WriteLine("\n########### Calculate Area of Rectangle ###########\n");
            Console.Write("\t\tEnter Length : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t\tEnter Breadth : ");
            int b = Convert.ToInt32(Console.ReadLine());

            s.area(l,b);
        }
    }
}
