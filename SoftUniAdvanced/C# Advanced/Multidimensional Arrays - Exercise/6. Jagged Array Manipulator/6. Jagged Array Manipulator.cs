using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                matrix[row] = inputDimensions;
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        int currNum = matrix[row][col];
                        int belowCurrNum = matrix[row + 1][col];
                        matrix[row][col] = currNum * 2;
                        matrix[row + 1][col] = belowCurrNum * 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        int currNum = matrix[row][col];
                        matrix[row][col] = currNum / 2;
                    }

                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        int belowCurrNum = matrix[row + 1][col];
                        matrix[row + 1][col] = belowCurrNum / 2;
                    }
                }
            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //"Add {row} {column} {value}" - add {value} to the element at the given indexes, if they are valid.
            //"Subtract {row} {column} {value}" - subtract {value} from the element at the given indexes, if they are valid.
            //"End" - print the final state of the matrix(all elements separated by a single space) and stop the program.

            while (commands[0] != "End")
            {
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                switch (command)
                {
                    case "Add":
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] -= value;
                        }
                        break;
                    default:
                        break;
                }

                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
