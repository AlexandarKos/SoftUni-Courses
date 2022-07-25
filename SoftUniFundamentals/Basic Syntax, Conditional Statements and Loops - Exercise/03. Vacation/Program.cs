using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0.0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = 8.45 * countPeople;
                    
                }
                else if (day == "Saturday")
                {
                    totalPrice = 9.80 * countPeople;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 10.46 * countPeople;
                }

                if (countPeople >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = 10.90 * countPeople;

                }
                else if (day == "Saturday")
                {
                    totalPrice = 15.60 * countPeople;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 16 * countPeople;
                }

                if (countPeople >= 100)
                {
                    
                    totalPrice -= totalPrice / countPeople * 10;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = 15 * countPeople;

                }
                else if (day == "Saturday")
                {
                    totalPrice = 20 * countPeople;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 22.50 * countPeople;
                }

                if (countPeople >= 10 && countPeople <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
