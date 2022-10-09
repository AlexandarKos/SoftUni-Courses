using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                regularGuests.Remove(input);
                vipGuests.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(regularGuests.Count + vipGuests.Count);

            if (vipGuests.Count > 0)
            {
                Console.WriteLine($"{String.Join("\n", vipGuests)}");
            }
            if (regularGuests.Count > 0 )
            {
                Console.WriteLine($"{String.Join("\n", regularGuests)}");
            }
        }
    }
}
