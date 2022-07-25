using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double currCoin = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double currCoin = 0.0; //double.Parse(input);
            double totalBalance = 0.0;
            while (input != "Start")
            {
                currCoin = double.Parse(input);
                if (currCoin == 0.1 || currCoin == 0.2 || currCoin == 0.5 || currCoin == 1 || currCoin == 2)
                {
                    totalBalance += currCoin;                    
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoin}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Nuts")
                {
                    if (totalBalance >= 2.0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        totalBalance -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (totalBalance >= 0.7)
                    {
                        Console.WriteLine($"Purchased water");
                        totalBalance -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (totalBalance >= 1.5)
                    {
                        Console.WriteLine($"Purchased crisps");
                        totalBalance -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (totalBalance >= 0.8)
                    {
                        Console.WriteLine($"Purchased soda");
                        totalBalance -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (totalBalance >= 1.0)
                    {
                        Console.WriteLine($"Purchased coke");
                        totalBalance -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Change: {totalBalance:f2}");
        }
    }
}
