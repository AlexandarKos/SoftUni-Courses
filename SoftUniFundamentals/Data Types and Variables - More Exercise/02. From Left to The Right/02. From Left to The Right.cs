using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                String[] integerList = input.Split();
                long leftNumber = long.Parse(integerList[0]);
                long rightNumber = long.Parse(integerList[1]);
                long biggerNumber = Math.Max(leftNumber, rightNumber);
                //char[] charrArray = biggerNumber.ToString().ToCharArray();
                // int sum = 0;
                //for (int value = 0; value < charArray.Length; value++)
                //{
                //    sum += int.Parse(charArray[value].ToString());
                //}
                biggerNumber = Math.Abs(biggerNumber);
                long sum = 0;                
                while (biggerNumber != 0)
                {
                    sum += biggerNumber % 10;
                    biggerNumber /= 10;
                }
                Console.WriteLine(sum);
            }           
        }
    }
}
