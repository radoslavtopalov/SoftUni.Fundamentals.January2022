using System;
using System.Linq;

namespace _04.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Check failing third zero test
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (var i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    Console.Write(input[input.Length - 1]);
                    break;
                }

                if (input[i] > input[i + 1])
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
