using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the budget statists and price for clothing
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            // get price for decor which is 10% from the budget
            double decorPrice = budget * 0.10;

            // get the price for all the clothing
            double totalPrice = statists * clothing;
            if (statists > 150)
            {                
                totalPrice *= 0.9;
                // totalPrice = totalPrice - totalPrice * 0.1;
            }

            double priceNeeded = decorPrice + totalPrice;
            if (budget < priceNeeded)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - priceNeeded):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budget - priceNeeded):F2} leva left.");
            }
        }
    }
}
