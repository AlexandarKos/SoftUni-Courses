using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int currentResult = 1;
            while (currentResult <= maxNumber)
            {
                Console.WriteLine(currentResult);
                currentResult = currentResult * 2 + 1;
            }
        }
    }
}
