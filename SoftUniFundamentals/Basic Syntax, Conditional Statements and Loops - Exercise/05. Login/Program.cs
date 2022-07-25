using System;
using System.Text;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);
            string password = new string(charArray);

            int invalidLogin = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input != password)
                {
                    invalidLogin++;
                    if (invalidLogin > 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    //input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
