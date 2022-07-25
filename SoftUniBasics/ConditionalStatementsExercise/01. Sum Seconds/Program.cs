using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the time of runners
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            // get the total time of the runners
            int totalTime = firstTime + secondTime + thirdTime;

            // seperate the total time into minutes and seconds
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            // print the result in the correct format
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
