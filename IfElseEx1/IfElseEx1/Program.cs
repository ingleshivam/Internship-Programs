using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity, price, amount;
            double discount;
            string cityName;

            Console.Write("Enter quantity : ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price :");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the city name : ");
            cityName = Console.ReadLine();

            if (cityName == "Pune")
            {
                amount = quantity * price;
                discount = amount * 0.2;
                Console.WriteLine("Amount is :" + amount);
                Console.WriteLine("Discount is: " + discount);
            }
            else
            {
                amount = quantity * price;
                discount = amount * 0.1;
                Console.WriteLine("Amount is :" + amount);
                Console.WriteLine("Discount is: " + discount);
            }

        }
    }
}
