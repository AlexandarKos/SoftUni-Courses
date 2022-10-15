using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static Action<int[]> output = x => Console.WriteLine($"{x.Count()}\n{x.Sum()}");
        static void Main(string[] args)
        {
            output(Console.ReadLine()
                          .Split(", ")
                          .Select(int.Parse)
                          .ToArray());
        }
    }
}