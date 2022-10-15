//Create a simple program that reads from the console a set of integers
//and prints back on the console the smallest number from the collection.
//Use Func<T, T>.
//
using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> calcMin =
            x => x.Min();

            int[] nums = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(calcMin(nums));
        }
    }
}
