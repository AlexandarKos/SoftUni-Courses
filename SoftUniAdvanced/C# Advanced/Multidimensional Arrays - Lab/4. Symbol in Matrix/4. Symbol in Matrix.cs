using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = input[col];

                }
            }

            char symbolToMatch = char.Parse(Console.ReadLine());

            bool isPresent = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currSymbol = matrix[row, col];

                    if (currSymbol == symbolToMatch)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isPresent = true;
                        break;
                    }
                }

                if (isPresent)
                {
                    break;
                }
            }

            if (!isPresent)
            {
                Console.WriteLine($"{symbolToMatch} does not occur in the matrix");
            }
        }
    }
}
