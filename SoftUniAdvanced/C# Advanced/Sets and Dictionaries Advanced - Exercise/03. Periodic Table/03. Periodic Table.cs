using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompund = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int c = 0; c < chemicalCompund.Length; c++)
                {
                    periodicTable.Add(chemicalCompund[c]);
                }
            }

            Console.WriteLine(String.Join(" ", periodicTable));
        }
    }
}
