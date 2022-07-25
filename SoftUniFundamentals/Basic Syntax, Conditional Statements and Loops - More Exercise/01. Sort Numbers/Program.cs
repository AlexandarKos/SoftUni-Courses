using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num > num2 && num > num3)
            {
                Console.WriteLine(num);
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            else if (num2 > num && num2 > num3)
            {
                Console.WriteLine(num2);
                if (num > num3)
                {
                    Console.WriteLine(num);
                    Console.WriteLine(num3);
                }
                else
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num);
                }
            }
            else if (num3 > num && num3 > num2)
            {
                Console.WriteLine(num3);
                if (num > num2)
                {
                    Console.WriteLine(num);
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num);
                }
            }            
        }
    }
}