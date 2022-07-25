using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the hour and minutes from the user

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // convert the hours to minutes 

            minutes = minutes + hour * 60;

            // add 15 minutes to the time

            int timeAfter15 = minutes + 15;
            // get hours and minutes variables the time addition

            int hoursAfter = timeAfter15 / 60;
            int minutesAfter = timeAfter15 % 60;

            // Print the result according to the example "часове:минути" => 2:01 / 0:14
            if (hoursAfter > 23)
            {
                hoursAfter = 0;               
            }

            if (minutesAfter < 10)
            {
                Console.WriteLine($"{hoursAfter}:0{minutesAfter}");
            }
            else
            {
                Console.WriteLine($"{hoursAfter}:{minutesAfter}");
            }            
        }
    }
}
