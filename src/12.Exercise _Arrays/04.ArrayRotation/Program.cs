using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rotationCount = int.Parse(Console.ReadLine()!);

            for (var rotation = 0; rotation < rotationCount; rotation++)
            {
                var firstElement = input[0];
                for (var i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }
                input[input.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}