using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long startingPower = long.Parse(Console.ReadLine());
            long distance = long.Parse(Console.ReadLine());
            short exhaustionFactor = short.Parse(Console.ReadLine());

            long currPower = startingPower;
            int pokedCount = 0;
            while (currPower >= distance)
            {
                currPower -= distance;
                pokedCount++;
                if (startingPower * 0.5 == currPower && exhaustionFactor > 0)
                {
                    currPower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currPower);
            Console.WriteLine(pokedCount);
        }
    }
}
