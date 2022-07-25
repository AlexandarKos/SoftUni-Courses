using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input number of pen packages price
            double numPenPackages = double.Parse(Console.ReadLine()) * 5.80;
            // input number of markers packages price
            double numMarkersPackages = double.Parse(Console.ReadLine()) * 7.20;
            // input liters of board cleaner price
            double litersBoardCleaner = double.Parse(Console.ReadLine()) * 1.20;
            // input discount percentage
            double discountPercentage = double.Parse(Console.ReadLine())/100;

            // calculate total supplies price
            double totalPrice = numPenPackages + numMarkersPackages + litersBoardCleaner;
            // print total price with discount
            Console.WriteLine(totalPrice - (totalPrice * discountPercentage));
        }
    }
}
