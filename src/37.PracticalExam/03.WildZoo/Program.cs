using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WildZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Contains("EndDay"))
                {
                    break;
                }

                var newCommand = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries).Last()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                var animalName = newCommand[0].Trim();
                var neededFood = int.Parse(newCommand[1].Trim());

                if (command.Contains("Add"))
                {
                    var area = newCommand[2].Trim();

                    if (!animals.Any(a => a.Name == animalName))
                    {
                        animals.Add(new Animal { Area = area, Name = animalName, NeededFood = neededFood });
                    }
                    else
                    {
                        var animal = animals.Where(a => a.Name == animalName).First();
                        animal.NeededFood += neededFood;
                    }
                }

                if (command.Contains("Feed"))
                {
                    if (animals.Any(a => a.Name == animalName))
                    {
                        var animal = animals.Where(a => a.Name == animalName).First();

                        animal.NeededFood -= neededFood;

                        if (animal.NeededFood <= 0)
                        {
                            animals.Remove(animal);
                            Console.WriteLine($"{animal.Name} was successfully fed");
                        }
                    }
                }
            }

            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($" {animal.Name} -> {animal.NeededFood}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            var dist = animals.Select(a => a.Area).Distinct();
            foreach (var d in dist)
            {
                var sisNumber = animals.Count(a => a.Area == d);
                Console.WriteLine($"{d}: {sisNumber}");
            }
        }
    }

    public class Animal
    {
        public string Name { get; set; }

        public int NeededFood { get; set; }

        public string Area { get; set; }

    }
}
