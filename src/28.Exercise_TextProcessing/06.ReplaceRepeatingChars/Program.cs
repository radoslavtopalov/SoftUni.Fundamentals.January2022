using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.ToCharArray().ToList();
            var newString = new List<char>();

            for (var j = 1; j <= input.Count - 1; j++)
            {
                while (input[j - 1] == input[j])
                {
                    input.RemoveAt(j);

                    if (j >= input.Count)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}