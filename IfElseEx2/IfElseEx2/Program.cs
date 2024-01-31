using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxamount;
            int amount;
            string stateName;
            Console.Write("Ente the amount : ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the state name :");
            stateName = Console.ReadLine();

            if (stateName == "Maharashtra"){
                taxamount = amount * 0.1;
                Console.WriteLine("Tax Amount is :" + taxamount);
            }
            else {
                taxamount = amount * 0.2;
                Console.WriteLine("Tax Amount is :" + taxamount);
            }
        }
    }
}
