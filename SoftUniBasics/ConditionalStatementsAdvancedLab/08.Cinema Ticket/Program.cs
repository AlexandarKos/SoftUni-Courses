using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the day of the week and print the ticket price according to the day
            string dayOfWeek = Console.ReadLine();
            int ticketPrice;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    ticketPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    ticketPrice = 14;
                    break;              
                default:
                    ticketPrice = 16;
                    break;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}
