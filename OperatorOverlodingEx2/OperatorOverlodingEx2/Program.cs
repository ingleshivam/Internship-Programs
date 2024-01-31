using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverlodingEx2
{
    class Point
    {
        private int X;
        private int Y;
        
        public void addPoint(int a , int b)
        {
            this.X = a;
            this.Y = b;
        }

        public void displayPoint()
        {
            Console.WriteLine("X : " + X);
            Console.WriteLine("Y : " + Y);
        }

        public static Point operator ++(Point p1)
        {
            p1.X++;
            p1.Y++;

            return p1;
        }

        public static Point operator --(Point p1)
        {
            p1.X--;
            p1.Y--;

            return p1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.addPoint(2, 3);
            Console.WriteLine("Initial Values");
            p1.displayPoint();
            p1++;
            p1++;
            p1++;
            Console.WriteLine("After Increment by 3");
            p1.displayPoint();
            p1--;
            p1--;
            Console.WriteLine("After Decrement by 2");
            p1.displayPoint();
        }
    }
}
