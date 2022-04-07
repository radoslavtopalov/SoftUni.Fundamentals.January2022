using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var number = int.Parse(Console.ReadLine()!);

            for (var i = 0; i < input.Length; i++)
            {
                for (var j = i + 1; j < input.Length; j++)
                {
                    var areEqual = input[i] + input[j] == number;

                    if (areEqual)
                    {
                        Console.WriteLine(input[i] + " " + input[j]);
                    }
                }
            }
        }
    }
}