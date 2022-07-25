using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate the volume using the following formula: π * r^2 * h.

            short n = short.Parse(Console.ReadLine());
            float biggestVolume = 0;
            string biggestModel = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = (float)(Math.PI * radius * radius * height);

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
