using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
		// Fields
		private string name;
        private int age;

		// Constructors
		public Person()
		{
			this.Name = "No name";
			this.Age = 1;
		}

		public Person(int age) : this()
		{
			this.Age=age;
		}

		public Person(string name, int age) : this(age)
		{
			this.Name = name;			
		}

        // Properties
        public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		// Methods
		public override string ToString()
		{
			return $"{this.Name} - {this.Age}";
		}
	}	
}