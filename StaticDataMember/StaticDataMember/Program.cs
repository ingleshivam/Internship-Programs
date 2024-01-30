using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataMember
{
    //Static Data Member
    class Sample {
        //Without Static

        private int count = 0;
        public void incrementCount()
        {
            this.count++;
            Console.WriteLine("Count is :" + count);
        }

        //With static

        //private static int count = 0;
        //public void incrementCount()
        //{
        //    count++;
        //    Console.WriteLine("Count is :" + count);
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Static
            //Output 1 1 1 1
            Sample s = new Sample();
            s.incrementCount();

            Sample s1 = new Sample();
            s1.incrementCount();

            Sample s2 = new Sample();
            s2.incrementCount();

            Sample s3 = new Sample();
            s3.incrementCount();

            //With Static
            //Sample s = new Sample();
            //s.incrementCount();

            //Sample s1 = new Sample();
            //s1.incrementCount();

            //Sample s2 = new Sample();
            //s2.incrementCount();

            //Sample s3 = new Sample();
            //s3.incrementCount();
        }
    }
}
