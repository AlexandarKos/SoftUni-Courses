using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPerHour = int.Parse(Console.ReadLine());
            int secondPerHour = int.Parse(Console.ReadLine());
            int thirdPerHour = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalPerHour = firstPerHour + secondPerHour + thirdPerHour;
            int totalHours = 0;
            int breakNeeded = 0;

            while (studentsCount > 0)
            {
                totalHours++;
                breakNeeded++;
                if (breakNeeded == 4 )
                {
                    breakNeeded = 0;
                    continue;
                }
                studentsCount -= totalPerHour;
            }

            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}