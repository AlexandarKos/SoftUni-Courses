using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the hour and day of the week
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            // print open or closed according to working hours (monday to saturday from 10-18)
            if (dayOfWeek != "Sunday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
