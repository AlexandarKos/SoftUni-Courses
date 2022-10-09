using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read a list of integers and print the largest 3 of them. If there are less than 3, print all of them.

            int[] integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToArray();

            Console.WriteLine(String.Join(" ", integers));

            // int[] integers = Console.ReadLine()
            //.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //.Select(int.Parse)
            //.ToArray();

            //int[] sorted = integers.OrderByDescending(n => n).Take(3).ToArray();

            //Console.WriteLine(String.Join(" ", integers));
        }
    }
}
