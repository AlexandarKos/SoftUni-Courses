using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the vacation price and the number of each toy by the user

            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            // get the price for all the toys

            double totalPrice = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            //get the number of toys and check if a discount is requried

            int toysNumber = puzzles + dolls + bears + minions + trucks;
            if (toysNumber >=50)
            {
                totalPrice *= 0.75;
                // totalPrice = totalPrice - totalPrice * 0.25;
            }

            // remove the 10% for rent from the total price            
            totalPrice = totalPrice - totalPrice * 0.10;

            // Print the result according to the examples =>
            // "Yes! {оставащите пари} lv left."
            // "Not enough money! {недостигащите пари} lv needed."

            if (totalPrice >= vacationPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - vacationPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalPrice - vacationPrice):F2} lv needed.");
            }
        }
    }
}