using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the type or profection and number of rows and columns
            string ticketType = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            // calculate and print the total sum of tickets for full room
            double totalPrice = rows * columns;
            if (ticketType == "Premiere")
            {
                totalPrice *= 12.00;
            }
            else if (ticketType == "Normal")
            {
                totalPrice *= 7.50;
            }
            else
            {
                totalPrice *= 5.00;
            }
            Console.WriteLine($"{totalPrice:f2} leva");
        }
    }
}
