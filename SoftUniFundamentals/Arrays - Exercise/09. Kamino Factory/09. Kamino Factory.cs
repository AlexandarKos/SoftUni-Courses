using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequenceLength];
            int dnaSum = 0;
            int dnaCount = 1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;

            int sample = 0;
            while (input != "Clone them!")
            {
                // current DNA info
                sample++;
                int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                // current DNA elements
                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDnaSum = 0;
                bool isCurrDnaBetter = false;
                int count = 0;
                for (int i = 0; i < currDNA.Length; i++)
                {
                    if (true)
                    {

                    }
                }
            }

        }
    }
}
