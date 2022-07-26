using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 4 3 2 => 4 3 2
            // numbers[0] > numbers[i +1]
            // 
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isBigger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] <= numbers[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
