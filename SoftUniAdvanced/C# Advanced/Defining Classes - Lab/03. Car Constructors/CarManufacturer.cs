﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CarManufacturer
{	
    class Car
    {
		private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.FuelQuantity = 200;
			this.FuelConsumption = 10;
		}

		public Car(string make, string model, int year)
			: this()
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}

		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
		}

        public string Make
		{
			get { return make; }
			set { make = value; }
		}		

		public string Model
		{
			get { return model; }
			set { model = value; }
		}		

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}

		public void Drive(double distance)
		{
			double leftFuel = fuelQuantity - (distance * fuelConsumption);
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