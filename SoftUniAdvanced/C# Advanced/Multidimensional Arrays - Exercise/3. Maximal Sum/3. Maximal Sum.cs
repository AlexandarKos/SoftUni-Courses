using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

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

            int sumOfMatrix = int.MinValue;

            int squareRowStart = 0;
            int squareColStart = 0;

            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {
                    int currSum = 0;

                    for (int innerRow = 0; innerRow < 3; innerRow++)
                    {
                        for (int innerCol = 0; innerCol < 3; innerCol++)
                        {
                            currSum += matrix[row + innerRow, col + innerCol];
                        }
                    }

                    if (currSum > sumOfMatrix )
                    {
                        sumOfMatrix = currSum;
                        squareRowStart = row;
                        squareColStart = col;
                    }                    
                }
            }

            Console.WriteLine($"Sum = {sumOfMatrix}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{matrix[squareRowStart + row, squareColStart + col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
