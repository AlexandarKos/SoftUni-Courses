using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalPriceWithoutTax = 0.00;
            double specialDiscount = 0.90;
            double tax = 0.20;
            double totalTaxes = 0.0;
            double totalPriceWithTaxes = 0.0;

            while (input != "regular" && input != "special")
            {
                double currPrice = double.Parse(input);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                totalPriceWithoutTax += currPrice;

                input = Console.ReadLine();
            }

            if (totalPriceWithoutTax <= 0)
            {
                Console.WriteLine($"Invalid order!");
            }
            else
            {
                if (input == "regular")
                {
                    totalTaxes = totalPriceWithoutTax * tax;
                    totalPriceWithTaxes = totalPriceWithoutTax + totalTaxes;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
                    Console.WriteLine($"Taxes: {totalTaxes:f2}$");
                    Console.WriteLine($"-----------");
                    Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");

                }
                else if (input == "special")
                {
                    totalTaxes = totalPriceWithoutTax * tax;
                    totalPriceWithTaxes = totalPriceWithoutTax + totalTaxes;
                    totalPriceWithTaxes *= specialDiscount;
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
                    Console.WriteLine($"Taxes: {totalTaxes:f2}$");
                    Console.WriteLine($"-----------");
                    Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
                }
            }
        }
    }
}
