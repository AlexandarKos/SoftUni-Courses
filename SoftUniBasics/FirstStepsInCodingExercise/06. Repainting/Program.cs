using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input nylon quantity plus extra
            int nylonQuantity = int.Parse(Console.ReadLine()) + 2;
            // input liters of paint quantity
            double litersPaint = double.Parse(Console.ReadLine());
            // input thinner in liters
            int thinner = int.Parse(Console.ReadLine());
            // input hours for work
            int workingHours = int.Parse(Console.ReadLine());

            // get the total price for the supplies
            litersPaint += litersPaint * 0.10;
            double totalNylonQuantity = nylonQuantity * 1.50;
            double totalLitersPaint = litersPaint * 14.50;
            double totalThinner = thinner * 5.00;

            double fullSuppliesPrice = totalNylonQuantity + totalLitersPaint + totalThinner + 0.40;
            // get the price for the workers

            double workersSum = (fullSuppliesPrice * 0.30) * workingHours;

            // print the final sum of supplies plus workers payment
            Console.WriteLine(fullSuppliesPrice + workersSum);
        }
    }
}
