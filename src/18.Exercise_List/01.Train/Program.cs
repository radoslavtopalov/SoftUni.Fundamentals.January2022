using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var maxPassengers = int.Parse(Console.ReadLine()!);

            while (true)
            {
                var command = Console.ReadLine()!;


                if (command.Contains("end"))
                {
                    break;
                }

                if (command.Contains("Add"))
                {
                    var passengersNumber = command.Split("Add ", StringSplitOptions.RemoveEmptyEntries);
                    wagons.Add(int.Parse(passengersNumber.First()));

                    continue;
                }

                var passengersToAdd = int.Parse(command);

                for (var i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + passengersToAdd <= maxPassengers)
                    {
                        wagons[i] += passengersToAdd;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}