using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that sums all numbers in a list in the following order:
            //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

            //Input             Output

            //1 2 3 4 5         6 6 3
            //1 2 3 4           5 5

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            if (numbers.Count % 2 == 0 )
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
