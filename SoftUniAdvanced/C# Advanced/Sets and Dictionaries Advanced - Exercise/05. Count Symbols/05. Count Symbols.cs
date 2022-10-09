using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsCount.ContainsKey(input[i]))
                {
                    symbolsCount.Add(input[i], 0);
                }

                symbolsCount[input[i]]++;
            }

            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
