using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double totalSpentOnGames = 0.0;

            //If game not present => "Not Found" and read the next line.
            //If $0 left, print "Out of money!" and end the program.
            //If buying a game that can't afford => "Too Expensive" and read the next line.
            //If the game gets bought => "Bought {nameOfGame}"            
            double currGamePrice = 0.0;
            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        currGamePrice = 39.99;
                        break;
                    case "CS: OG":
                        currGamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        currGamePrice = 19.99;
                        break;
                    case "Honored 2":
                        currGamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        currGamePrice = 29.99;
                        break;
                    default:
                        currGamePrice = 0;
                        Console.WriteLine("Not Found");
                        input = Console.ReadLine();
                        break;
                }
                if (balance >= currGamePrice && currGamePrice != 0)
                {
                    totalSpentOnGames += currGamePrice;
                    balance -= currGamePrice;
                    Console.WriteLine($"Bought {input}");
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    input = Console.ReadLine();
                }
                else if (balance < currGamePrice)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                }                
                //input = Console.ReadLine();
            }
            //When you receive "Game Time", print the user's remaining money and total spent on games, rounded to the 2nd decimal place.
            if (input == "Game Time")
            {
                //Console.WriteLine($"{totalSpentOnGames}:f2");
                Console.WriteLine($"Total spent: ${totalSpentOnGames:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
