using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            for (int i = 0; i < judges; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                points += (judgeName.Length * judgePoints) / 2;
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
            if (points <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
