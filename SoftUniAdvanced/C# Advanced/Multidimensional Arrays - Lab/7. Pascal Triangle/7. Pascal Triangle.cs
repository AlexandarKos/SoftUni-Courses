using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (row == 0)
                    {
                        pascalTriangle[row][col] = 1;
                        continue;
                    }

                    long currentValue = 0;

                    if (col > 0 && row > 0)
                    {
                        currentValue += pascalTriangle[row - 1][col - 1];
                    }

                    if (pascalTriangle[row].Length - 1 > col)
                    {
                        currentValue += pascalTriangle[row - 1][col];
                    }

                    pascalTriangle[row][col] = currentValue;
                }
            }

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write($"{pascalTriangle[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
