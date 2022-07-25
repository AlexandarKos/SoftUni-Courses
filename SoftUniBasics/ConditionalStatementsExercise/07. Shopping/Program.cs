using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input by the user
            double budget = double.Parse(Console.ReadLine());
            int graphicCardNumber = int.Parse(Console.ReadLine());
            int cpuNumber = int.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());

            // get the prices for the products
            double graphicCardPrice = graphicCardNumber * 250.0;
            double cpuPrice = cpuNumber * (graphicCardPrice * 0.35);
            double ramPrice = ramNumber * (graphicCardPrice * 0.10);

            // calculate the total sum needed and if the budget will be enough
            double totalPrice = graphicCardPrice + cpuPrice + ramPrice;
            
            if (graphicCardNumber > cpuNumber)
            {
                double discount = totalPrice * 0.15;
                totalPrice-=discount;
            }
            
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {(budget - totalPrice):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budget):F2} leva more!");
            }
        }
    }
}
