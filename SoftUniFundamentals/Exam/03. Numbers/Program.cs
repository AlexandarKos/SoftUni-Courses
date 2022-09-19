using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> topNumbers = new List<int>();

            double average = Queryable.Average(numbers.AsQueryable());

            foreach (var num in numbers)
            {
                if (num > average)
                {
                    topNumbers.Add(num);
                }
            }

            var descendingOrder = topNumbers.OrderByDescending(n => n);

            List<int> topFiveOrLessDescending = descendingOrder.Take(5).ToList();

            if (topFiveOrLessDescending.Count() < 1)
            {
                Console.WriteLine("No");                
            }
            else
            {
                Console.WriteLine(String.Join(" ", topFiveOrLessDescending));
            }
        }
    }
}
