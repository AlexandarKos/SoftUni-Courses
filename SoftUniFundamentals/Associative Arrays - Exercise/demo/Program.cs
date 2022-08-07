using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // name and price            
            Dictionary<string, double> ordersPrice = new Dictionary<string, double>();

            // name and quantity
            Dictionary<string, int> ordersQuantity = new Dictionary<string, int>();

            //string[] input = Console.ReadLine().Split().ToArray();

            string productName = "Beer";
            double productPrice = 1.20;
            int productQuantity = 100;

            ordersPrice.Add(productName, productPrice);
            ordersQuantity.Add(productName, productQuantity);

            Console.WriteLine(ordersQuantity[productName]);

            //while (input[0] != "buy")
            //{
            //    string productName = input[0];
            //    double productPrice = double.Parse(input[1]);
            //    int productQuantity = int.Parse(input[2]);

            //    if (!ordersPrice.ContainsKey(productName))
            //    {
            //        //If the product doesn't exist yet, add it with its starting quantity.
            //        ordersPrice.Add(productName, productPrice);
            //        ordersQuantity.Add(productName, productQuantity);
            //    }
            //    else
            //    {
            //        ordersQuantity[productName] += productQuantity;
            //        if (ordersPrice[productName] != productQuantity)
            //        {

            //        }
            //    }
            //}
        }
    }
}
