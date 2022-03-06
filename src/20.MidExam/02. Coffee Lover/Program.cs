using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // var coffeeInStock = new List<string>();

            var coffeeInStock = Console.ReadLine()
                .Split(" ")
                .ToList();
            var commandsCount = int.Parse(Console.ReadLine());


            for (var i = 0; i < commandsCount; i++)
            {
                var commandInput = Console.ReadLine();

                if (commandInput.Contains("Include"))
                {
                    coffeeInStock.Add(commandInput.Split(" ").LastOrDefault());
                }
                else if (commandInput.Contains("Remove"))
                {
                    var position = commandInput.Split(" ")[1];
                    var numberOfIndices = int.Parse(commandInput.Split(" ").LastOrDefault());

                    if (numberOfIndices > coffeeInStock.Count)
                    {
                        continue; // might have an issue
                    }

                    if (position.Contains("last"))
                    {
                        coffeeInStock.RemoveRange(coffeeInStock.Count - numberOfIndices, numberOfIndices);
                    }
                    else
                    {
                        coffeeInStock.RemoveRange(0, numberOfIndices);
                    }
                }
                else if (commandInput.Contains("Prefer"))
                {
                    var indices = commandInput.Split(" ").ToList();
                    indices.RemoveAt(0);

                    var indecesInts = new List<int>();
                    var higherIndex = int.MinValue;

                    for (var j = 0; j < indices.Count; j++)
                    {
                        indecesInts.Add(int.Parse(indices[j]));
                    }

                    for (var j = 0; j < indecesInts.Count; j++)
                    {
                        if (indecesInts[j] > higherIndex)
                        {
                            higherIndex = indecesInts[j];
                        }
                    }

                    if (higherIndex <= coffeeInStock.Count - 1)
                    {
                        var firstElement = coffeeInStock[indecesInts[0]];
                        var secondElement = coffeeInStock[indecesInts[1]];

                        coffeeInStock[indecesInts[0]] = secondElement;
                        coffeeInStock[indecesInts[1]] = firstElement;

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandInput.Contains("Reverse"))
                {
                    coffeeInStock.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            for (var i = 0; i < coffeeInStock.Count; i++)
            {
                Console.Write(coffeeInStock[i] + " ");
            }
        }
    }
}
