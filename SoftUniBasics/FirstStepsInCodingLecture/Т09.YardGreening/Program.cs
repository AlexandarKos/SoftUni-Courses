using System;

namespace Т09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input total square meters
            double totalSquareMeters = double.Parse(Console.ReadLine());
            // price for one square meter
            double priceForOneSquare = 7.61;
            // discount input
            double discount = 0.18;
            // price for total square meters
            double priceTotalSquare = totalSquareMeters * priceForOneSquare;
            // total discount 
            double totalDiscount = discount * priceTotalSquare;

            Console.WriteLine($"The final price is: {priceTotalSquare - totalDiscount}");
            Console.WriteLine($"The discount is: {totalDiscount} lv.");
        }
    }
}
