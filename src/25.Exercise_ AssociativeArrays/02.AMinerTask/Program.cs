using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resources = Console.ReadLine();
            var dicInput = new Dictionary<string, int>();

            while (resources != "stop")
            {
                var quantity = int.Parse(Console.ReadLine()!);

                if (dicInput.ContainsKey(resources))
                {
                    dicInput[resources] += quantity;
                }
                else
                {
                    dicInput.Add(resources, quantity);
                }

                resources = Console.ReadLine();
            }


            foreach (var pair in dicInput)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}