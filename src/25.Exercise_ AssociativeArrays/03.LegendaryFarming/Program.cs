using System;
using System.Collections.Generic;

namespace _03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["motes"] = 0,
                ["fragments"] = 0

            };
            var input = Console.ReadLine()
                .Split(' ');
            var junk = new Dictionary<string, int>();


            while (true)
            {
                for (var i = 0; i < input.Length - 1; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = input[i + 1].ToLower();

                    if (resources.ContainsKey(material))
                    {
                        resources[material] += quantity;

                        if (resources[material] >= 250)
                        {
                            var items = material == "shards"
                                ? "Shadowmourne"
                                : material == "fragments"
                                    ? "Valanyr"
                                    : material == "motes"
                                        ? "Dragonwrath"
                                        : default;

                            Console.WriteLine($"{items} obtained!");

                            foreach (var resource in resources)
                            {
                                var value = resource.Value;
                                if (value >= 250)
                                {
                                    value -= 250;
                                }

                                Console.WriteLine($"{resource.Key}: {value}");
                            }

                            foreach (var jun in junk)
                            {
                                Console.WriteLine($"{jun.Key}: {jun.Value}");
                            }
                            return;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                input = Console.ReadLine()
                    .Split(' ');
            }
        }
    }
}
