using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingEx1
{
    class Weight
    {
        private int Kg;
        private int Gm;

        public void addWeight(int a, int b)
        {
            this.Kg = a;    
            this.Gm = b;
        }

        public void displayWeight()
        {
            Console.WriteLine("Kg : " + this.Kg);
            Console.WriteLine("Gm : " + this.Gm);
        }

        public static Weight operator +(Weight t1, Weight t2)
        {
            Weight temp = new Weight();
            temp.Gm = t1.Gm + t2.Gm;
            if(temp.Gm >= 1000)
            {
                temp.Kg = temp.Gm / 1000;
                temp.Gm = temp.Gm % 1000;
            }

            temp.Kg = t1.Kg + t2.Kg + temp.Kg;
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Weight w1 = new Weight();
            w1.addWeight(10, 800);
            w1.displayWeight();

            Weight w2 = new Weight();
            w2.addWeight(20, 800);
            w2.displayWeight();

            Weight w3 = w1 + w2;
            w3.displayWeight();
        }
    }
}
