using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());          

            List<string> command = Console.ReadLine().ToLower().Split().ToList();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        int firstNumAdd = int.Parse(command[1]);
                        int secondNumAdd = int.Parse(command[2]);
                        numbers.Push(firstNumAdd);
                        numbers.Push(secondNumAdd);
                        break;
                    case "remove":
                        int numToRemove = int.Parse(command[1]);
                        if (numbers.Count < numToRemove)
                        {
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < numToRemove; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().ToLower().Split().ToList();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");

            //int sumOfElements = 0;

            //foreach (int num in numbers)
            //{
            //    sumOfElements += num;
            //}

            //Console.WriteLine($"Sum: {sumOfElements}");
        }
    }
}
