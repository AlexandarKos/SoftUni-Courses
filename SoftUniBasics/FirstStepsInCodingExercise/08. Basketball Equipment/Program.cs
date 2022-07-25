using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the yearly price for basketball training
            int trainingPrice = int.Parse(Console.ReadLine());
            // get the sneakers price => 40% less than the training price
            double sneakersPrice = trainingPrice - trainingPrice * 0.40;

            // get the basketball outfit price => 20% less than the sneakers price
            double outfitPrice = sneakersPrice - sneakersPrice * 0.20;
            // get the basketball ball price => 1/4 of the outfit price
            double ballPrice = outfitPrice / 4;
            // get the accessoaries price => 1/5 of the ball price
            double accessoriesPrice = ballPrice / 5;

            // get total price
            double totalPrice = trainingPrice + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;
            // print total price
            Console.WriteLine(totalPrice);
        }
    }
}
