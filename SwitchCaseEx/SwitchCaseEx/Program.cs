using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            double discountPrice;
            string cityName;

            Console.WriteLine("Enter amount :");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter city name :");
            cityName = Console.ReadLine();

            switch (cityName) {
                case "Pune":
                    discountPrice = amount * 0.4;
                    break;
                case "Mumbai":
                    discountPrice = amount * 0.3;
                    break;
                case "Pcmc":
                    discountPrice = amount * 0.2;
                    break;
                case "Delhi":
                    discountPrice = amount * 0.1;
                    break;
                default:
                    discountPrice = amount * 0.05;
                    break;
            }
            Console.WriteLine("Discount Price is :" + discountPrice);
        }
    }
}
