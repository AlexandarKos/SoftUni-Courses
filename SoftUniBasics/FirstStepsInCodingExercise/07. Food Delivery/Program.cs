using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input number of chicken menu orders
            double chickenOrders = double.Parse(Console.ReadLine())* 10.35;
            // input number of fish menu orders
            double fishOrders = double.Parse(Console.ReadLine()) * 12.40;
            // input number of vegetarian menu orders
            double vegetarianorders = double.Parse(Console.ReadLine()) * 8.15;
            // calculate total prices for the menus
            double totalMenuPrices = chickenOrders + fishOrders + vegetarianorders;
            // calculate desert price
            double desertPrice = (totalMenuPrices) * 0.20;
            // get total price of the order
            double delivery = 2.50;
            double totalPrice = totalMenuPrices + desertPrice + delivery;

            // print the total price of the order

            Console.WriteLine(totalPrice);
        }
    }
}
