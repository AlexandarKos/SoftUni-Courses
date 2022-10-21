//Use your Person class from the previous tasks. Create a class Family.
//The class should have a list of people, a method for adding members -
//void AddMember(Person member), and a method returning
//the oldest family member – Person GetOldestMember().
//Write a program that reads the names and ages of N people and adds them to the family.
//Then print the name and age of the oldest member. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        public static void Main()
        {
            Family family = new Family();
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] currPersonDetails = Console.ReadLine().Split();
                string personName = currPersonDetails[0];
                int personAge = int.Parse(currPersonDetails[1]);
                Person person = new Person(personName, personAge);
                family.AddMember(person);
            }

            Person[] filteredPeople = family.PeopleFamily
                            .FindAll(p => p.Age > 30)
                            .OrderBy(p => p.Name)
                            .ToArray();                            

            foreach (Person person in filteredPeople)
                Console.WriteLine(person);
        }
    }
}