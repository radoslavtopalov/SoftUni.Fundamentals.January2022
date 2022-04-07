using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrays = Console.ReadLine()!
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var numbers = new List<int>();

            for (var i = arrays.Count - 1; i >= 0; i--)
            {
                var currentArray = arrays[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse);

                foreach (var number in currentArray)
                {
                    numbers.Add(number);
                }
            }

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}