using System;
using System.Linq;

namespace _02.MatrixAndDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string racingNumber = Console.ReadLine();
            char[,] matrix = new char[n, n];
            int currRow = 0;
            int currCol = 0;
            int kmPassed = 0;

            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        matrix[row, col] = 'C';
                    }
                    else
                    {
                        matrix[row, col] = line[col];
                    }
                }
            }

            string directions = Console.ReadLine();

            bool hasFinished = false;

            while (directions != "End")
            {
                int oldRow = currRow;
                int oldCol = currCol;

                switch (directions)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                    default:
                        break;
                }

                if (matrix[currRow, currCol] == 'T')
                {
                    kmPassed += 30;
                    matrix[oldRow, oldCol] = '.';
                    matrix[currRow, currCol] = '.';

                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'T')
                            {
                                matrix[row, col] = 'C';
                                currRow = row;
                                currCol = col;                                
                            }
                        }
                    }


                }
                else if (matrix[currRow, currCol] == '.')
                {
                    kmPassed += 10;
                    matrix[oldRow, oldCol] = '.';
                    matrix[currRow, currCol] = 'C';
                }
                else if (matrix[currRow, currCol] == 'F')
                {
                    kmPassed += 10;
                    matrix[oldRow, oldCol] = '.';
                    matrix[currRow, currCol] = 'C';
                    hasFinished = true;
                    break;
                }

                //Console.WriteLine("-------------------------------");

                //for (int row = 0; row < n; row++)
                //{
                //    for (int col = 0; col < n; col++)
                //    {
                //        Console.Write(matrix[row, col]);
                //    }

                //    Console.WriteLine();
                //}

                directions = Console.ReadLine();
            }

            if (hasFinished == false)
            {
                Console.WriteLine($"Racing car {racingNumber} DNF.");
            }
            else if (hasFinished == true)
            {
                Console.WriteLine($"Racing car {racingNumber} finished the stage!");
                //Console.WriteLine($"Distance covered {kmPassed} km.");
            }

            Console.WriteLine($"Distance covered {kmPassed} km.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
