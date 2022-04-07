using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    public class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            while (true)
            {
                var input = Console.ReadLine()!;
                if (input == "End")
                    break;

                var inputArr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var vehicleType = char.ToUpper(inputArr[0][0]) + inputArr[0].Substring(1);
                var model = inputArr[1];
                var color = inputArr[2];
                var horsepower = int.Parse(inputArr[3]);

                if (vehicles.Any(v => v.Model == model))
                {
                    continue;
                }
                var newVehicle = new Vehicle
                { Type = vehicleType, Model = model, Color = color, Horsepower = horsepower };
                vehicles.Add(newVehicle);
            }

            while (true)
            {
                var input = Console.ReadLine()!;
                if (input == "Close the Catalogue")
                    break;

                var print = vehicles.FirstOrDefault(v => v.Model == input);

                Console.WriteLine($"Type: {print.Type}");
                Console.WriteLine($"Model: {print.Model}");
                Console.WriteLine($"Color: {print.Color}");
                Console.WriteLine($"Horsepower: {print.Horsepower}");
            }

            double carsHorsePowers = 0;
            double trucksHorsepowers = 0;
            if (vehicles.Any(v => v.Type.Contains("Car")))
            {
                carsHorsePowers = vehicles
                    .Where(v => v.Type.Contains("Car"))
                    .Select(v => v.Horsepower)
                    .Average();
            }

            if (vehicles.Any(v => v.Type.Contains("Truck")))
            {
                trucksHorsepowers = vehicles
                   .Where(v => v.Type.Contains("Truck"))
                   .Select(v => v.Horsepower)
                   .Average();
            }

            Console.WriteLine($"Cars have average horsepower of: {carsHorsePowers:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHorsepowers:F2}.");
        }
    }
}
