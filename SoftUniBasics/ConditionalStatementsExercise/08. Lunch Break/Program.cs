using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input by the user
            string seriesName = Console.ReadLine();
            int seriesLength = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            // calculate the time left for watching TV series

            double lunchTime = breakTime / 8.0;
            double restTime = breakTime / 4.0;

            double timeLeft = breakTime - lunchTime - restTime;

            // print the result according to the template
            // "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            // "You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            if (timeLeft >= seriesLength)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - seriesLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(Math.Abs(timeLeft - seriesLength))} more minutes.");
            }
        }
    }
}