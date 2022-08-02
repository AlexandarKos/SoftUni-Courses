using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("/").ToList();
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input[0] != "end")
            {
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int horsePower = 0;
                int weight = 0;

                if (type == "Truck")
                {
                    weight = int.Parse(input[3]);
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    trucks.Add(truck);
                    
                }
                else
                {
                    horsePower = int.Parse(input[3]);
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    cars.Add(car);
                }
                
                input = Console.ReadLine().Split("/").ToList();
            }

            //With LINQ: yourList.OrderBy(x => x).ToList()

            List<Truck> orderedTrucks = trucks.OrderBy(truck => truck.Brand).ToList();
            List<Car> orderedCars = cars.OrderBy(car => car.Brand).ToList();

            CatalogVehicle catalogVehicles = new CatalogVehicle(orderedTrucks, orderedCars);

            Console.WriteLine("Cars:");
            foreach (var car in catalogVehicles.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalogVehicles.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
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
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
}