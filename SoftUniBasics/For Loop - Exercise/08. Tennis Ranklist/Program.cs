using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentNumber = int.Parse(Console.ReadLine());
            int finalPoints = int.Parse(Console.ReadLine());

            double winsPercentage = 0.0;
            double averagePoints = 0.0;
            for (int i = 0; i < tournamentNumber; i++)
            {
                string outcome = Console.ReadLine();

                if (outcome == "W")
                {
                    winsPercentage++;
                    finalPoints += 2000;
                    averagePoints += 2000;
                }
                else if (outcome == "F")
                {
                    finalPoints += 1200;
                    averagePoints += 1200;
                }
                else if (outcome == "SF")
                {
                    finalPoints += 720;
                    averagePoints += 720;
                }


            }

            averagePoints /= tournamentNumber;
            winsPercentage = (winsPercentage / tournamentNumber) * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{winsPercentage:f2}%");
        }
    }
}
