using System;
using System.Collections.Generic;
using System.Data;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsToPass = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> carsQueue = new Queue<string>();

            int totalCarsPassed = 0;

            while (input != "end")
            {
                if (input != "green")
                {
                    carsQueue.Enqueue(input);
                }
                else
                {
                    int maxNumber = Math.Min(carsQueue.Count, numberOfCarsToPass);

                    for (int i = 0; i < maxNumber; i++)
                    {
                        string currCar = carsQueue.Dequeue();
                        Console.WriteLine($"{currCar} passed!");
                        totalCarsPassed++;
                    }
                }

                if (input == "green")
                {

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
