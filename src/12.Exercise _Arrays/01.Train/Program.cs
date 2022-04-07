using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wagonsCount = int.Parse(Console.ReadLine()!);
            var wagonsPassengers = new int[wagonsCount];
            var allPassengers = 0;

            for (var i = 0; i < wagonsCount; i++)
            {
                var passengersPerWagon = int.Parse(Console.ReadLine()!);

                wagonsPassengers[i] = passengersPerWagon;
                allPassengers += passengersPerWagon;
            }

            foreach (var wagonsPassenger in wagonsPassengers)
            {
                Console.Write($"{wagonsPassenger} ");
            }
            Console.WriteLine("\n" + allPassengers);
        }
    }
}