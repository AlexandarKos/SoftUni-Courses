using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            OrderPrice(product, quantity);
        }

        static void OrderPrice(string product, int quantity)
        {
            double singlePrice = 0;
            switch (product)
            {
                case "water":
                    singlePrice = 1.00;
                    break;
                case "coffee":
                    singlePrice = 1.50;
                    break;
                case "coke":
                    singlePrice = 1.40;
                    break;
                case "snacks":
                    singlePrice = 2.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{(singlePrice * quantity):f2}");
        }
    }
}
