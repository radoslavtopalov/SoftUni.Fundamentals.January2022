using System;
using System.Linq;

namespace _06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (var i = 0; i < input.Length; i++)
            {
                var leftSum = input.Take(i).Sum();
                var rightSum = input.Skip(i + 1).Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
