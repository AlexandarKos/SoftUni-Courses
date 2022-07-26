using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] firstArray = new int[numberOfElements];
            int[] secondArray = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }
            }
            Console.WriteLine(String.Join(' ', firstArray));
            Console.WriteLine(String.Join(' ', secondArray));
        }
    }
}
