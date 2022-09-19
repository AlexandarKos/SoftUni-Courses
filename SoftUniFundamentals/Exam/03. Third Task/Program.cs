using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Third_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int capacityTotalMsgPerUser = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split("=").ToArray();

            // name and sent            
            Dictionary<string, int> usersSent = new Dictionary<string, int>();

            // name and received
            Dictionary<string, int> usersReceived = new Dictionary<string, int>();

            while (input[0] != "Statistics")
            {
                //The possible commands are:
                //"Statistics"
                //"Add={username}={sent}={received}"
                //"Message={sender}={receiver}"
                //"Empty={username}"
                string command = input[0];
                switch (command)
                {
                    case "Add":
                        string usernameToAdd = input[1];
                        int sentByUser = int.Parse(input[2]);
                        int receivedByUser = int.Parse(input[3]);

                        if (usersSent.ContainsKey(usernameToAdd))
                        {
                            break;
                        }
                        else
                        {
                            int test = sentByUser + receivedByUser;
                            if (capacityTotalMsgPerUser > test && sentByUser >=0 && receivedByUser >= 0)
                            {
                                usersSent.Add(usernameToAdd, sentByUser);
                                usersReceived.Add(usernameToAdd, receivedByUser);
                            }
                        }

                        break;
                    case "Message":
                        string sender = input[1];
                        string receiver = input[2];

                        if (usersSent.ContainsKey(sender) && usersReceived.ContainsKey(receiver))
                        {
                            usersSent[sender]++;
                            usersReceived[receiver]++;

                            int currTotalBySender = usersSent[sender] + usersReceived[sender];
                            int currTotalByReceiver = usersSent[receiver] + usersReceived[receiver];

                            if (currTotalBySender >= capacityTotalMsgPerUser)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                usersSent.Remove(sender);
                                usersReceived.Remove(sender);
                            }

                            if (currTotalByReceiver >= capacityTotalMsgPerUser)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                usersSent.Remove(receiver);
                                usersReceived.Remove(receiver);
                            }
                        }

                        break;
                    case "Empty":
                        string usernameToRemove = input[1];

                        if (usernameToRemove == "All")
                        {
                            usersSent.Clear();
                            usersReceived.Clear();
                        }
                        else
                        {
                            if (usersSent.ContainsKey(usernameToRemove))
                            {
                                usersSent.Remove(usernameToRemove);
                                usersReceived.Remove(usernameToRemove);
                            }
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split("=").ToArray();
            }

            //"Users count: {count}
            //{ username1} - { number of messages}
            //{ username2}
            //- { number of messages}

            int totalMessagesCurrUser = 0;
            int totalUsers = usersSent.Count;

            Console.WriteLine($"Users count: {totalUsers}");

            foreach (var userSen in usersSent)
            {
                foreach (var userRece in usersReceived)
                {
                    if (userSen.Key == userRece.Key)
                    {
                        string currUser = userSen.Key;
                        totalMessagesCurrUser = userSen.Value + userRece.Value;
                        //Console.WriteLine(currUser);
                        Console.WriteLine($"{currUser} - {totalMessagesCurrUser}");
                    }
                }
            }
        }
    }
}
