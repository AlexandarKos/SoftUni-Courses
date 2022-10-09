using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string currString = string.Empty;

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "END")
            {                
                if (commands.Length == 5)
                {
                    string swap = commands[0];
                    int firstRow = int.Parse(commands[1]);
                    int firstCol = int.Parse(commands[2]);
                    int secondRow = int.Parse(commands[3]);
                    int secondCol = int.Parse(commands[4]);

                    if (swap == "swap"
                        && firstRow >= 0
                        && firstRow < matrix.GetLength(0)
                        && firstCol >= 0
                        && firstCol < matrix.GetLength(1)
                        && secondRow >= 0
                        && secondRow < matrix.GetLength(0)
                        && secondCol >= 0
                        && secondCol < matrix.GetLength(1))
                    {
                        currString = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = currString;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}