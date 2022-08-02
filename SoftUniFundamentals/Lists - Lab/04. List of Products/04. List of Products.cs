using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
                //string input = Console.ReadLine();
            }
            products.Sort();
            int coutner = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{coutner}.{product}");
                coutner++;
            }
            //Console.WriteLine(products.Count);
            //Console.WriteLine(String.Join(" ", products));
        }
    }
}
