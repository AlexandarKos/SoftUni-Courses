using System;

namespace _02.Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read the day of the week
            string day = Console.ReadLine();

            // print according to examples

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
