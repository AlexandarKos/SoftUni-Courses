using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            short capacity = 255;
            short occupied = 0;
            
            for (int i = 0; i < n; i++)
            {
                ushort liters = ushort.Parse(Console.ReadLine());
                if (liters <= capacity)
                {
                    capacity -= (short)liters;
                    occupied += (short)liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                //liters = ushort.Parse(Console.ReadLine());
            }
            Console.WriteLine(occupied);
        }
    }
}
