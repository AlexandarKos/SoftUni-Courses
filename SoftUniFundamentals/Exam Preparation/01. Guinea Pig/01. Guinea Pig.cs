using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· On the first line – quantity food in kilograms - a floating - point number in the range[0.0…10000.0].
            //· On the second line – quantity hay in kilograms - a floating - point number in the range[0.0…10000.0].
            //· On the third line – quantity cover in kilograms - a floating - point number in the range[0.0…10000.0].
            //· On the fourth line – guinea's weight in kilograms - a floating-point number in the range [0.0…10000.0].
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());

            double foodIngrams = food * 1000;
            double hayIngrams = hay * 1000;
            double coverIngrams = cover * 1000;
            double pigWeightIngrams = pigWeight * 1000;

            //Calculate whether the quantity of food, hay and cover will be enough for a month.
            //If Merry runs out of food, hay, or cover, stop the program!

            bool isEnough = true;

            for (int i = 1; i <= 30; i++)
            {
                //Every day Puppy eats 300 gr of food.
                foodIngrams -= 300;

                //Every second day Merry first feeds the pet, then gives it a certain amount of hay equal to 5 % of the rest of the food.
                if (i % 2 == 0)
                {
                    double fivePercentOfCurrentFood = foodIngrams * 0.05;
                    hayIngrams -= fivePercentOfCurrentFood;
                }

                //On every third day, Merry puts Puppy cover with a quantity of 1 / 3 of its weight.
                if (i % 3 == 0)
                {
                    double coverToRemove = Math.Round(pigWeightIngrams / 3, 2);
                    coverIngrams -= coverToRemove;
                }

                //If one of the things is not enough, print:
                //"Merry must go to the pet store!"
                if (foodIngrams <= 0 || hayIngrams <= 0 || coverIngrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    isEnough = false;
                    break;
                }
            }

            if (isEnough)
            {
                //If the food, the hay and the cover are enough, print:
                //"Everything is fine! Puppy is happy! Food: {excessFood}, Hay: {excessHay}, Cover: {excessCover}."
                //The output values must be formatted to the second decimal place!
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodIngrams / 1000):f2}, Hay: {(hayIngrams / 1000):f2}, Cover: {(coverIngrams / 1000):f2}.");
            }
        }
    }
}
