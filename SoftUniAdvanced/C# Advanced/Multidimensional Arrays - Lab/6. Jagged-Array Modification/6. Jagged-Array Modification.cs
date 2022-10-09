using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = input;
            }

            string[] commandInput = Console.ReadLine().Split();

            while (commandInput[0] != "END")
            {
                string command = commandInput[0];
                int row = int.Parse(commandInput[1]);
                int col = int.Parse(commandInput[2]);
                int value = int.Parse(commandInput[3]);

                switch (command)
                {
                    case "Add":
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    case "Subtract":
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                    default:
                        break;
                }

                commandInput = Console.ReadLine().Split();
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