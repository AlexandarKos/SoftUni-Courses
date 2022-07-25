using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input the product, town and quantity by the user
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            // print the total sum according to prices in each town
            double totalSum = 0.0;
            switch (dayOfWeek)
            {
                case "Monday":                
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = quantity * 2.50;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "apple":
                            totalSum = quantity * 1.20;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "orange":
                            totalSum = quantity * 0.85;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "grapefruit":
                            totalSum = quantity * 1.45;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "kiwi":
                            totalSum = quantity * 2.70;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "pineapple":
                            totalSum = quantity * 5.50;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "grapes":
                            totalSum = quantity * 3.85;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;                            
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            totalSum = quantity * 2.70;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "apple":
                            totalSum = quantity * 1.25;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "orange":
                            totalSum = quantity * 0.90;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "grapefruit":
                            totalSum = quantity * 1.60;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "kiwi":
                            totalSum = quantity * 3.00;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "pineapple":
                            totalSum = quantity * 5.60;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        case "grapes":
                            totalSum = quantity * 4.20;
                            Console.WriteLine("{0:F2}", totalSum);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;                
                default:
                    Console.WriteLine("error");
                    break;
            }            
        }
    }
}
