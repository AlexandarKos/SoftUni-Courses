using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> productShop = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                string shopName = input[0];
                string productName = input[1];
                double price = double.Parse(input[2]);

                if (!productShop.ContainsKey(shopName))
                {
                    productShop.Add(shopName, new Dictionary<string, double>());
                }

                productShop[shopName].Add(productName, price);

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in productShop)
            {
                //fantastico->
                //Product: apple, Price: 1.2
                //Product: grape, Price: 2.2

                Console.WriteLine($"{item.Key}->");

                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
