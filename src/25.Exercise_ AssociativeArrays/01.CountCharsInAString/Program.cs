using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ')
                .Select(s => s.ToCharArray())
                .ToList();
            var letters = new Dictionary<char, int>();

            foreach (var str in input)
            {
                foreach (var chr in str)
                {
                    if (letters.ContainsKey(chr))
                    {
                        letters[chr] += 1;
                    }
                    else
                    {
                        letters[chr] = 1;
                    }
                }
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}