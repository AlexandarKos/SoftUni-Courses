using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the time distance and speed for the swimming
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double meterInSeconds = double.Parse(Console.ReadLine());

            // calculate the resistance
            double neededTime = distance * meterInSeconds;
            double resistanceTime = Math.Floor(distance / 15) * 12.5;
            double totalTime = neededTime + resistanceTime;
            // double secDifference = 0;

            // print the result accourding to template below
            // "Yes, he succeeded! The new world record is {времето на Иван} seconds."
            // "No, he failed! He was {недостигащите секунди} seconds slower."

            if (totalTime < recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
                                
            }
            else
            {
                //secDifference = totalTime - recordTime;
                Console.WriteLine($"No, he failed! He was {(totalTime - recordTime):F2} seconds slower.");
            }
        }
    }
}
