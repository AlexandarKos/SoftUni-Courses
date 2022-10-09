using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputMainMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = inputMainMatrix[0];
            int cols = inputMainMatrix[1];
            int[,] matrix = new int[rows, cols]; // главната матрица

            // пълним главната матрица с дата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int n = int.Parse(Console.ReadLine()); // динамични пропорции на вътрешна матрица

            int maxSum = int.MinValue; // тук пазим сумата на най-голямата вътрешна матрица

            // пазим откъде ще почва най-голямата вътрешна матрица 
            int squareStartRow = 0; 
            int squareStartCol = 0;
            
            for (int row = 0; row <= matrix.GetLength(0) - n; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - n; col++)
                {
                    // създаваме сума за сегашната проверка на потенциална матрица
                    int currSum = 0;

                    for (int innerRow = 0; innerRow < n; innerRow++)
                    {
                        for (int innerCol = 0; innerCol < n; innerCol++)
                        {                            
                            currSum += matrix[row + innerRow, col + innerCol];
                        }
                    }

                    // ако сме намерили по-голяма матрица, ъпдейтваме сумата и откъде почва
                    if (currSum > maxSum)
                    {                        
                        maxSum = currSum;
                        squareStartRow = row;
                        squareStartCol = col;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[squareStartRow + row, squareStartCol + col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);

            // 3x3

            // 11, 21, 31, 41, 51, 78
            // 61, 71, 81, 91, 10, 73
            // 11, 12, 13, 14, 15, 63
            // 16, 17, 18, 19, 20, 15
            // 21, 22, 23, 24, 25, 12
            // 26, 27, 28, 29, 30, 12
        }
    }
}
