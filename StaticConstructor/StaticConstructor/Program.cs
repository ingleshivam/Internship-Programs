using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    //static class Sample
    //{
    //    private static int count = 0;
    //    static Sample()
    //    {
    //        count = 0;
    //    }

    //    public static void incCount()
    //    {
    //        count++;
    //        Console.WriteLine("Count is : "+count);
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Sample.incCount();
    //        Sample.incCount();
    //        Sample.incCount();
    //        Sample.incCount();
    //    }
    //}

    class Sample
    {
        private int count = 0;

        public Sample()
        {
            count=0;
        }
        
        public void incCount()
        {
            count++;
            Console.WriteLine("Count is : "+count);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.incCount();

            Sample s1 = new Sample();
            s1.incCount();

            Sample s2 = new Sample();
            s2.incCount();

            Sample s3 = new Sample();
            s3.incCount();

        }
    }
}
