using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEx1
{
    class Search
    {
        public bool doSearch(int[] data, int n)
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
            int[] integerArray = new int[5];
            string[] stringArray = new string[5];

            Console.WriteLine("########## Enter Integers in Array ##########");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter integer at index "+(i+1)+" : ");
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter integer number that you want to find : ");
            int findInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n########## Enter Strings in Array ##########");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter string at index " + (i +1)+ " : ");
                stringArray[i] = Console.ReadLine();
            }

            Console.Write("\nEnter string that you want to find : ");
            string findString = Console.ReadLine();


            Search s = new Search();
            if (s.doSearch(integerArray, findInteger))
            {
                Console.WriteLine("\nInteger Found");
            }
            else
            {
                Console.WriteLine("\nInteger Not Found");
            }

            if (s.doSearch(stringArray, findString)){
                Console.WriteLine("String Found\n");
            }
            else
            {
                Console.WriteLine("String Not Found\n");
            }
        }
    }
}
