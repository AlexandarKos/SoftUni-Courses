using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCount = 0;
            int totalExtractedSpice = 0;

            while (startingYield >= 100)
            {
                daysCount++;
                totalExtractedSpice += startingYield;
                totalExtractedSpice -= 26;
                startingYield -= 10;
            }
            if (totalExtractedSpice >= 26)
            {
                totalExtractedSpice -= 26;
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalExtractedSpice);
        }
    }
}
