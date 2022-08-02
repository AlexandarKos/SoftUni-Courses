using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
            //After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well
            //Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available)

            //Input                 Output              Explanation

            //3 3 6 1               12 1                3 3 6 1 => 6 6 1 => 12 1
            //8 2 2 4 8 16          16 8 16             8 2 2 4 8 16 => 8 4 4 8 16 => 8 8 8 16 => 16 8 16
            //5 4 2 1 1 4           5 8 4               5 4 2 1 1 4 => 5 4 2 2 4 => 5 4 4 4 => 5 8 4

            List<double> inputList = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] += inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", inputList));
        }
    }
}
