using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            //A valid username
            //has length between 3 and 16 characters
            //contains only letters, numbers, hyphens and underscore

            foreach (var username in usernames)
            {
                //foreach (var username in usernames.Where(n => n.Length >= 3 && n.Length <= 16))

                    if (username.Length >= 3 && username.Length <= 16)
                    {
                    bool isValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        char currChar = username[i];

                        if (!(currChar == '-' || currChar == '_' || char.IsLetterOrDigit(currChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}