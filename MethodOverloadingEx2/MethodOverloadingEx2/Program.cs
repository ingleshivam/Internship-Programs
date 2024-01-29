using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEx2
{
    class Shape
    {
        public double calculateArea(double r)
        {
            double pie = 3.14;
            double calculateAreaOfCircle = pie * r * r;
            return calculateAreaOfCircle;
        }

        public int calculateArea(int l, int b)
        {
            int calculateAreaOfRectangle = l * b;
            return calculateAreaOfRectangle;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Console.Write("######### Calculate Area of Circle #########");
            Console.Write("\nEnter radius :");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaOfCircleResult = s.calculateArea(radius);
            Console.WriteLine("\nArea of Circle : " + areaOfCircleResult);

            Console.Write("\n######### Calculate Area Of Rectangle #########");
            Console.Write("\nEnter Length :");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Breadth :");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int areaOfRectangleResult = s.calculateArea(length,breadth);
            Console.WriteLine("\nArea of Rectangle : " + areaOfRectangleResult+"\n");
        }
    }
}
