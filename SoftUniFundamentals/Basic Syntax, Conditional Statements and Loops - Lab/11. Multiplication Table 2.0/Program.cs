using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());


            for (int i = number; i <= 10; i++)
            {
                //if (multiplier > 10)
                //{
                //    Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
                //    break;
                //}
                Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
            }
            if (number > 10)
            {
                Console.WriteLine($"{multiplier} X {number} = {multiplier * number}");
            }
        }
    }
}
