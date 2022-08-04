using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input[0] != "End")
            {
                string typeOfVehicle = input[0];
                string model = input[1];
                string color = input[2];
                double horsepower = int.Parse(input[3]);

                if (typeOfVehicle == "truck")
                {
                    Truck truck = new Truck(color, model, horsepower);
                    trucks.Add(truck);
                }
                else
                {                  
                    Car car = new Car(color, model, horsepower);
                    cars.Add(car);
                }

                input = Console.ReadLine().Split().ToList();
            }

            string vehicleModel = Console.ReadLine();

            while (vehicleModel != "Close the Catalogue")
            {
                if (trucks.Any(truck => truck.Model.Contains(vehicleModel)))
                {
                    Truck currTruck = trucks.Find(truck => truck.Model == vehicleModel);
                    Console.WriteLine($"Type: Truck");
                    Console.WriteLine($"Model: {currTruck.Model}");
                    Console.WriteLine($"Color: {currTruck.Color}");
                    Console.WriteLine($"Horsepower: {currTruck.Horsepower}");
                }
                else
                {
                    Car currCar = cars.Find(car => car.Model == vehicleModel);
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {currCar.Model}");
                    Console.WriteLine($"Color: {currCar.Color}");
                    Console.WriteLine($"Horsepower: {currCar.Horsepower}");
                }
                vehicleModel = Console.ReadLine();
            }
            //double totalCarHorsepower = 0;
            //double totalTruckHorsepower = 0;

            //foreach (var car in cars)
            //{
            //    totalCarHorsepower += car.Horsepower;
            //}

            //foreach (var truck in trucks)
            //{
            //    totalTruckHorsepower += truck.Horsepower;
            //}

            //int numberOfCars = cars.Count;
            //int numberOfTrucks = trucks.Count;
            //double averageCarHorsePower = 0.00;
            //double averageTruckHorsePower = 0.00;

            //if (numberOfCars > 0)
            //{
            //    averageCarHorsePower = totalCarHorsepower / numberOfCars;
            //}
            //if (numberOfTrucks > 0)
            //{
            //    averageTruckHorsePower = totalTruckHorsepower / numberOfTrucks;
            //}
            double averageCarHorsePower = cars.Count > 0 ? cars.Average(car => car.Horsepower) : 0.00;
            double averageTruckHorsePower = trucks.Count > 0 ? trucks.Average(truck => truck.Horsepower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");            
        }
    }

    class CatalogVehicle
    {
        public CatalogVehicle(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
    class Truck
    {
        public Truck(string color, string model, double horsepower)
        {
            Color = color;
            Model = model;
            Horsepower = horsepower;
        }

        public string Color { get; set; }

        public string Model { get; set; }

        public double Horsepower { get; set; }
    }
    class Car
    {
        public Car(string color, string model, double horsepower)
        {
            Color = color;
            Model = model;
            Horsepower = horsepower;
        }

        public string Color { get; set; }

        public string Model { get; set; }

        public double Horsepower { get; set; }
    }
}