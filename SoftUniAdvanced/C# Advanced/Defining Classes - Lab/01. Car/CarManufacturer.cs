using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
	public class StartUp
	{
		static void Main()
		{
			Car car = new Car();

			car.Make = "VW";
			car.Model = "MK3";
			car.Year = 1992;

			Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
		}
	}
    class Car
    {
		private string make;

		public string Make
		{
			get { return make; }
			set { make = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

	}
}
