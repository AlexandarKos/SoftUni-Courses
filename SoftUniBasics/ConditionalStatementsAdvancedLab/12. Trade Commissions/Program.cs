﻿using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the name of the city and number of sales
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            // calculate and print the commission according to example
            double commission = 0.0;
            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 0.05;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.07;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 0.045;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.10;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        commission = 0.055;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            double totalSum = sales * commission;
            if (commission > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }
            
        }
    }
}
