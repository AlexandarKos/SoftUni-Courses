using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            string[] input = Console.ReadLine().Split();

            int movesCount = 0;

            while (input[0] != "end")
            {
                int firstIndex = int.Parse(input[0]);
                int secondIndex = int.Parse(input[1]);
                movesCount++;

                if (IsOutOfBound(elements, firstIndex, secondIndex))
                {
                    string elementToAdd = $"-{movesCount}a";

                    elements.Insert(elements.Count / 2, elementToAdd);
                    elements.Insert(elements.Count / 2, elementToAdd);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        string currElement = elements[firstIndex];
                        elements.RemoveAll(ele => ele == currElement);
                        Console.WriteLine($"Congrats! You have found matching elements - {currElement}!");
                        if (elements.Count < 1)
                        {
                            Console.WriteLine($"You have won in {movesCount} turns!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                input = Console.ReadLine().Split();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elements));
            }
        }

        public static bool IsOutOfBound(List<string> elements, int firstIndex, int secondIndex)
        {
            if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0 || firstIndex > elements.Count - 1 || secondIndex > elements.Count - 1)
            {
                return true;
            }
            return false;
        }
    }
}