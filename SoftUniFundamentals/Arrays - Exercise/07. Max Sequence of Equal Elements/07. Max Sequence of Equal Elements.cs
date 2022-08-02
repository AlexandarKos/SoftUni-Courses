using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that finds the longest sequence of equal elements in an array of integers.
            //If several equal sequences are present in the array, print out the leftmost one.

            //Input                     Output

            //2 1 1 2 3 3 2 2 2 1       2 2 2
            //1 1 1 2 3 1 3 3           1 1 1
            //4 4 4 4                   4 4 4 4
            //0 1 1 5 2 2 6 3 3         1 1

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int currNum = 0;
            int lastNum = int.MinValue;
            int sequenceCounter = 0;
            int maxCounter = 0;
            int sequenceNum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                currNum = input[i];

                if (currNum == lastNum)
                {
                    sequenceCounter++;
                }
                else
                {
                    sequenceCounter = 1;
                }

                if (sequenceCounter > maxCounter)
                {
                    maxCounter = sequenceCounter;
                    sequenceNum = currNum;
                }
                lastNum = currNum;
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{sequenceNum} ");
            }
        }
    }
}
