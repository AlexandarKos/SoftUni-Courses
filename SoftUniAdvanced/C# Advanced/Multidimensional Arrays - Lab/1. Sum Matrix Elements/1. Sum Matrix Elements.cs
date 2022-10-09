 using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndColumns[0];
            int columns = rowsAndColumns[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);

            //int sumOfElements = matrix.Cast<int>().Sum();
            //Console.WriteLine(sumOfElements);

            int sum = 0;

            foreach (int num in matrix)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
