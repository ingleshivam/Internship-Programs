using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class Sample
    {
        public static void methodOne()
        {
            Console.WriteLine("Method Called in Static Class");
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
