using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] currPersonDetails = Console.ReadLine().Split();
                string personName = currPersonDetails[0];
                int personAge = int.Parse(currPersonDetails[1]);
                Person person = new Person(personName, personAge);
                persons.Add(person);
            }

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

        }
    }
}
