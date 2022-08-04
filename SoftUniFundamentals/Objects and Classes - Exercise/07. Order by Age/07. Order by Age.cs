using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputTokens = Console.ReadLine().Split().ToList();

            List<Person> persons = new List<Person>();

            while (inputTokens[0] != "End")
            {
                string name = inputTokens[0];
                string id = inputTokens[1];
                int age = int.Parse(inputTokens[2]);

                //Person person = new Person(name, id, age);
                //persons.Add(person);
                if (persons.Any(personId => personId.Id == id))
                {
                    Person currPerson = persons.Find(personId => personId.Id == id);
                    currPerson.UpdatePerson(currPerson, name, age);
                }
                else
                {
                    Person person = new Person(name, id, age);
                    persons.Add(person);
                }
                inputTokens = Console.ReadLine().Split().ToList();
            }

            foreach (var person in persons.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person}");
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public void UpdatePerson(Person person, string name, int age)
        {
            person.Name = name;
            person.Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {Id} is {Age} years old.";
    }
}
