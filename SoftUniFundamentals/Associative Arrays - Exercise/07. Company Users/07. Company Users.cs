using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"{companyName}
            // -- {employeeId}"

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ").ToArray();

            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeId = input[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }

                if (!companyUsers[companyName].Contains(employeeId))
                {
                    companyUsers[companyName].Add(employeeId);
                }

                input = Console.ReadLine().Split(" -> ").ToArray();
            }

            foreach (var company in companyUsers)
            {
                string companyName = company.Key;
                Console.WriteLine($"{companyName}");
                company.Value.ForEach(u => Console.WriteLine($"-- {u}"));
            }
        }
    }
}
