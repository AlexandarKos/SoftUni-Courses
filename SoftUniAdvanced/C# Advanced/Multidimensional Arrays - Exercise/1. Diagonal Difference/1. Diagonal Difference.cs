using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int leftToRightSum = 0;
            int rightToLeftSum = 0;

            for (int i = 0, j = size - 1; i < matrix.GetLength(0); i++, j--)
            {
                leftToRightSum += matrix[i, i];
                rightToLeftSum += matrix[j, i];
            }

            Console.WriteLine(Math.Abs(leftToRightSum - rightToLeftSum));
        }
    }
}
