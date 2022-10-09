using System;
using System.Linq;
using System.Numerics;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] chessBoard = new char[n, n];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] chessRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = chessRow[col];
                }
            }

            int knightsRemoved = 0;

            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;


                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        if (chessBoard[row, col] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, col, n, chessBoard);

                            if (countMostAttacking < attackedKnights)
                            {
                                countMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }
                    }
                }

                if (countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    chessBoard[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }
            }

            Console.WriteLine(knightsRemoved);
        }

        static int CountAttackedKnights(int row, int col, int n, char[,] chessBoard)
        {
            int attackedKnights = 0;

            // horizontal left - up
            if (IsCellValid(row - 1, col - 2, n))
            {
                if (chessBoard[row - 1, col -2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsCellValid(row - 1, col + 2, n))
                   {
                       if (chessBoard[row - 1, col + 2] == 'K')
                       {
                           attackedKnights++;
                       }
                   }

            if (IsCellValid(row + 2, col + 1, n))
            {
                if (chessBoard[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsCellValid(row + 2, col - 1, n))
            {
                if (chessBoard[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }       

            if (IsCellValid(row - 2, col + 1, n))
            {
                if (chessBoard[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsCellValid(row - 2, col - 1, n))
            {
                if (chessBoard[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsCellValid(row + 1, col + 2, n))
            {
                if (chessBoard[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            if (IsCellValid(row + 1, col - 2, n))
            {
                if (chessBoard[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        static bool IsCellValid(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }
    }
}
