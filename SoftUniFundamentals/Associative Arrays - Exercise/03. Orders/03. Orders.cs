﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // name and price            
            Dictionary<string, double> ordersPrice = new Dictionary<string, double>();

            // name and quantity
            Dictionary<string, int> ordersQuantity = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "buy")
            {
                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int productQuantity = int.Parse(input[2]);

                if (!ordersPrice.ContainsKey(productName))
                {
                    ordersPrice.Add(productName, productPrice);
                    ordersQuantity.Add(productName, productQuantity);
                }
                else
                {

                }
            }

        }
    }

    //class Product
    //{
    //    public Product(string name, double price, int quantity)
    //    {
    //        Name = name;
    //        Price = price;
    //        Quantity = quantity;
    //    }

    //    public void UpdateProduct(int quantity, double price)
    //    {
    //        Quantity = quantity;
    //        if (Price != price)
    //        {
    //            Price = price;
    //        }
    //    }

    //    public string Name { get; set; }

    //    public double Price { get; set; }

    //    public int Quantity { get; set; }

    //    public override string ToString() => $"{Name} -> {(Price * Quantity):f2}";
    //}
}
