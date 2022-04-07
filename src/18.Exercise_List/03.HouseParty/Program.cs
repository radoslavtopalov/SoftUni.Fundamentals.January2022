using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commandsCount = int.Parse(Console.ReadLine()!);
            var guests = new List<string>();

            for (var i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine()!;
                var guest = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).First();

                if (command.Contains("is going!"))
                {
                    if (guests.All(g => g != guest))
                    {
                        guests.Add(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Any(g => g == guest))
                    {
                        guests.Remove(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}