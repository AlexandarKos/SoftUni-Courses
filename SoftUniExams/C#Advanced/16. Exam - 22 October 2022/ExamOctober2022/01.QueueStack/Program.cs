using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace _01.QueueStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will receive a sequence of numbers representing milligrams of caffeinе.
            //On the second line, you will receive another sequence of numbers representing energy drinks.
            //It is important to know that the maximum caffeine Stamat can have for the night is 300 milligrams, and his initial is always 0.

            //To calculate the caffeine in the drink take the last milligrams of caffeinе and the first energy drink, and multiply them.Then, compare the result with the caffeine Stamat drank:
            //    • If the sum of the caffeine in the drink and the caffeine that Stamat drank doesn't exceed 300 milligrams, remove both the milligrams of caffeinе and the drink from their sequences. Also, add the caffeine to Stamat's total caffeine.
            //    • If Stamat is about to exceed his maximum caffeine per night, do not add the caffeine to Stamat’s total caffeine.Remove the milligrams of caffeinе and move the drink to the end of the sequence.Also, reduce the current caffeine that Stamat has taken by 30(Note: Stamat's caffeine cannot go below 0).
            //Stop calculating when you are out of drinks or milligrams of caffeine.
            //For more clarification, see the examples below.

            var caffeine = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            var energyDrinks = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int initialCaffeine = 0;


            while (energyDrinks.Any() && caffeine.Any())
            {

                int currentCaffeine = caffeine.Pop();
                int currentNrgDrink = energyDrinks.Dequeue();
                int caffeineInTheDrink = currentNrgDrink * currentCaffeine;
                if (caffeineInTheDrink + initialCaffeine <= 300)
                {
                    initialCaffeine += caffeineInTheDrink;
                }
                else
                {
                    energyDrinks.Enqueue(currentNrgDrink);
                    if (initialCaffeine - 30 >= 0)
                    {
                        initialCaffeine -= 30;
                    }
                    else
                    {
                        initialCaffeine = 0;
                    }
                }
            }

            if (energyDrinks.Count > 0)
            {
                Console.WriteLine($"Drinks left: " + String.Join(", ", energyDrinks));
            }
            else if (energyDrinks.Count == 0)
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {initialCaffeine} mg caffeine.");
        }
    }
}