using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverlodingEx1
{
    class Search
    {
        public bool doSearch(int [] data, int n)
        {
            bool result = false;
            foreach(int find in data)
            {
                if(find == n)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool doSearch(string[] data, string n)
        {
            bool result = false;
            foreach(string find in data)
            {
                if(find == n)
                {
                    result = true;
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Search s = new Search();

            int[] integerArray = new int[5];
            string[] stringArray = new string[5];

            int findInteger;
            string findString;

            Console.WriteLine("######### Input 5 Integers #########");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter Integer at index "+(i+1)+" : ");
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Integer that you want to find : ");
            findInteger = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n######### Input 5 Strings #########");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter String at index " + (i + 1) + " : ");
                stringArray[i] = Console.ReadLine();
            }

            Console.Write("Enter String that your want to find : ");
            findString = Console.ReadLine();

            if (s.doSearch(integerArray, findInteger))
            {
                Console.WriteLine("\nInterger Found");
            }
            else
            {
                Console.WriteLine("\nInteger Not Found");
            }
            
            if(s.doSearch(stringArray, findString))
            {
                Console.WriteLine("\nString Found");
            }
            else
            {
                Console.WriteLine("\nString Not Found");
            }
        }
    }
}
