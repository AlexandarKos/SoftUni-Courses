using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> carsInParkingLot = new HashSet<string>();

            while (input[0] != "END")
            {
                string action = input[0];
                string carNumber = input[1];

                if (action == "IN")
                {
                    carsInParkingLot.Add(carNumber);
                }
                else if (action == "OUT")
                {
                    carsInParkingLot.Remove(carNumber);

                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carsInParkingLot.Count > 0)
            {
                foreach (var car in carsInParkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
