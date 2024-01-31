using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperatorEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            double discount;
            string cityName;

            Console.Write("Enter the amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the city name :");
            cityName = Console.ReadLine();

            if(amount >=10000 && cityName == "Pune")
            {
                discount = amount * 0.2;
                Console.WriteLine("Discount apply : "+discount);
            }
            else
            {
                discount = amount * 0.1;
                Console.WriteLine("Discount apply : " + discount);
            }

        }
    }
}
