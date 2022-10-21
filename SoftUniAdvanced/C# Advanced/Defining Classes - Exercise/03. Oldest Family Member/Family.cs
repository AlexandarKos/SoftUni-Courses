using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        // Fields
        private List<Person> peopleFamily;

        // Constructors
        public Family()
        {
            this.peopleFamily = new List<Person>();
        }

        // Properties
        public List<Person> PeopleFamily
        {
            get { return peopleFamily; }
            set { peopleFamily = value; }
        }

        // Methods
        public void AddMember(Person member)
        {
            this.peopleFamily.Add(member);
        }

        public Person GetOldestMember()
        {
            return peopleFamily.OrderByDescending(p => p.Age).First();
        }
    }
}