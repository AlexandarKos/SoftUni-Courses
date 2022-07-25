using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());

            double totalProductPrice;
            double totalOrderPrice= 0.0;
            for (int i = 0; i < orderCount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                totalProductPrice = ((days * capsuleCount) * capsulePrice);
                Console.WriteLine($"The price for the coffee is: ${totalProductPrice:f2}");
                totalOrderPrice += totalProductPrice;
            }
            
            Console.WriteLine($"Total: ${totalOrderPrice:f2}");
        }
    }
}
