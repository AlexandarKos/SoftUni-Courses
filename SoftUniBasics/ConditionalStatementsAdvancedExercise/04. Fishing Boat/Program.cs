using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // прочитаме входните данни
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            // създаваме променлива за цената
            double price = 0.00;

            // 1) проверяваме сезона
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                        break;
                default:
                    break;
            }

            // 2) какъв е броя на рибарите и 
            // fisherman  <= 6 >>> 10%
            // fishermam <= 11 >>> 15%
            // fisherman > 11 >>> 25%

            if (fisherman <= 6)
            {
                price -= price * 0.10;
            }
            else if (fisherman <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }

            // 3) отстъпка ако fisherman % 2 == 0 и season != "Autumn"
            // => допълнителни 5%
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }

            // 4) дали budget е достатъчен (резултат:f2)
            // => "Yes! You have {останалите пари} leva left."
            // => "Not enough money! You need {сумата, която не достига} leva."
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
