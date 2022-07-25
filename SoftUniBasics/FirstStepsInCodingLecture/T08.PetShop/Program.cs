using System;

namespace T08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input count of dog food by user
            int dogFoodCount = int.Parse(Console.ReadLine());
            // input count of cat food by user
            int catFoodCount = int.Parse(Console.ReadLine());
            // logical solution for total food price
            double totalDogFood = dogFoodCount * 2.50;
            int totalCatFood = catFoodCount * 4;
            double totalFoodPrice = totalDogFood + totalCatFood;
            // print the result to the console
            Console.WriteLine($"{totalFoodPrice} lv.");
        }
    }
}
