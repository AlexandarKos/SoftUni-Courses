using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<PetrolPump> pumps = new Queue<PetrolPump>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int liters = input[0];
                int distance = input[1];
                PetrolPump newPetrolPump = new PetrolPump(liters, distance);
                pumps.Enqueue(newPetrolPump);
            }

            int counter = -1;

            while (true)
            {
                int currLiters = 0;
                bool valid = true;
                counter++;

                for (int i = 0; i < pumps.Count; i++)
                {
                    PetrolPump currPetrolPump = pumps.Dequeue();
                    currLiters += currPetrolPump.Liters;
                    currLiters -= currPetrolPump.Distance;
                    pumps.Enqueue(currPetrolPump);

                    if (currLiters < 0)
                    {
                        valid = false;
                    }

                }

                if (valid)
                {
                    Console.WriteLine(counter);
                    break;
                }

                if (counter > n)
                {
                    Console.WriteLine("No solution!");
                    break;
                }

                pumps.Enqueue(pumps.Dequeue()); 
            }
        }
    }

    class PetrolPump
    {
        public PetrolPump(int liters, int distance)
        {
            Liters = liters;
            Distance = distance;    
        }

        public int Liters { get; set; }

        public int Distance { get; set; }
    }
}
