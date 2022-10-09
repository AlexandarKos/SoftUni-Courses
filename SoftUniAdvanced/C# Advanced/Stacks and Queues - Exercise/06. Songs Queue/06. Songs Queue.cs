using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                switch (command)
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string songToAdd = String.Join(" ", input.Skip(1));

                        if (queue.Contains(songToAdd))
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");                            
                        }
                        else
                        {
                            queue.Enqueue(songToAdd);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", queue));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
