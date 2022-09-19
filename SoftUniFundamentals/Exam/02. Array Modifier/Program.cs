using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                string command = input[0];

                switch (command)
                {
                    case "swap":
                        int firstIndexToSwap = int.Parse(input[1]);
                        int secondIndexToSwap = int.Parse(input[2]);

                        int tempValue = inputNumbers[firstIndexToSwap];

                        inputNumbers[firstIndexToSwap] = inputNumbers[secondIndexToSwap];
                        inputNumbers[secondIndexToSwap] = tempValue;

                        break;
                    case "multiply":
                        int firstIndexToMultiply = int.Parse(input[1]);
                        int secondIndexToMultiply = int.Parse(input[2]);

                        inputNumbers[firstIndexToMultiply] = inputNumbers[secondIndexToMultiply] * inputNumbers[firstIndexToMultiply];
                        break;
                    case "decrease":
                        for (int i = 0; i < inputNumbers.Count; i++)
                        {
                            inputNumbers[i]--;
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(", ", inputNumbers));
        }
    }
}
