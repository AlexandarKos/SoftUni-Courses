 using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVagons = int.Parse(Console.ReadLine());
            int[] passangersArray = new int[numberOfVagons];
            int totalPassangers = 0;
            for (int i = 0; i < numberOfVagons; i++)
            {
                passangersArray[i] = int.Parse(Console.ReadLine());
                totalPassangers += passangersArray[i];
            }
            Console.WriteLine(String.Join(' ', passangersArray));
            Console.WriteLine(totalPassangers);
        }
    }
}
