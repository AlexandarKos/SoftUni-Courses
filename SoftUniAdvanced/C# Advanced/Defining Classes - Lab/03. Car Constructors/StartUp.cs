﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCare = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCare = new Car(make, model, year, fuelQuantity, fuelConsumption);
        }
    }
}