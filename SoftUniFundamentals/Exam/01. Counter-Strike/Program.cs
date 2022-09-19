using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string inputCommand = Console.ReadLine();

            int wonBattlesCount = 0;

            while (inputCommand != "End of battle")
            {
                int distance = int.Parse(inputCommand);

                if (energy >= distance)
                {
                    energy -= distance;
                    wonBattlesCount++;
                }
                else
                {
                    //energy = 0;
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattlesCount} won battles and {energy} energy");
                    break;
                }

                if (wonBattlesCount % 3 == 0)
                {
                    energy += wonBattlesCount;
                }

                inputCommand = Console.ReadLine();
            }

            if (inputCommand == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattlesCount}. Energy left: {energy}");
            }

        }
    }
}
