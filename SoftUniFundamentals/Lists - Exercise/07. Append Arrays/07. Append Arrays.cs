using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputOfList = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> numbers = new List<int>();
            
            foreach (var number in inputOfList)
            {
                numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
