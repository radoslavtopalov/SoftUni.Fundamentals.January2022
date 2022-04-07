using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numberOfLongestSequence = 0;
            var longestSequence = 1;

            var currentNumber = 0;
            var currentLongestSequence = 1;

            for (var i = 0; i < input.Length; i++)
            {
                var areEqual = false;
                if (i + 1 < input.Length)
                {
                    areEqual = input[i] == input[i + 1];
                }

                if (areEqual)
                {
                    currentNumber = input[i];
                    currentLongestSequence++;
                }

                if (!areEqual && currentLongestSequence > longestSequence)
                {
                    numberOfLongestSequence = currentNumber;
                    longestSequence = currentLongestSequence;
                }

                if (!areEqual)
                {
                    currentLongestSequence = 1;
                }
            }

            for (var i = 0; i < longestSequence; i++)
            {
                Console.Write(numberOfLongestSequence + " ");
            }
        }
    }
}