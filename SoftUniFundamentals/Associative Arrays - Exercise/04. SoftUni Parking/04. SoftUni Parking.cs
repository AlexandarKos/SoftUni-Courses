using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "register":
                        string username = commands[1];
                        string licensePlate = commands[2];

                        if (!registeredUsers.ContainsKey(username))
                        {
                            registeredUsers.Add(username, licensePlate);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {registeredUsers[username]}");
                        }
                        break;
                    case "unregister":
                        string unregisterUser = commands[1];                        

                        if (!registeredUsers.ContainsKey(unregisterUser))
                        {                            
                            Console.WriteLine($"ERROR: user {unregisterUser} not found");
                        }
                        else
                        {
                            registeredUsers.Remove(unregisterUser);
                            Console.WriteLine($"{unregisterUser} unregistered successfully");
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
