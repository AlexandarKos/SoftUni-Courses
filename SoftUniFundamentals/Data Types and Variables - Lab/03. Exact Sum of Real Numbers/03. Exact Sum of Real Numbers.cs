﻿using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal currNum = decimal.Parse(Console.ReadLine());
                totalSum += currNum;
            }
            Console.WriteLine(totalSum);
        }
    }
}