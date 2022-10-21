using System;
using System.Collections.Generic;
using System.IO;
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
			car.FuelQuantity = 200;
			car.FuelConsumption = 200;
			car.Drive(2000);
			Console.WriteLine(car.WhoAmI());

			//Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
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

		private double fuelQuantity;

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}

		private double fuelconsumption;

		public double FuelConsumption
		{
			get { return fuelconsumption; }
			set { fuelconsumption = value; }
		}

		public void Drive(double distance)
		{
			double leftFuel = fuelQuantity - (distance * fuelconsumption);
			if (leftFuel > 0)
			{
				fuelQuantity = leftFuel;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}
		}

		public string WhoAmI()
		{
			return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
		}
	}
}
