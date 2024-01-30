using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Sample
    {
        public static void methodOne()
        {
            Console.WriteLine("Static Method 1 Called");
            methodTwo();
        }

        public static void methodTwo()
        {
            Console.WriteLine("Static Method 2 Called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            Sample.methodOne();
        }
    }
}
