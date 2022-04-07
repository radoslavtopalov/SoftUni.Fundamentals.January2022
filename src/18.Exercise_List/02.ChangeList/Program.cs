using System;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine()!;

                if (command.Contains("end"))
                {
                    break;
                }

                if (command.Contains("Delete"))
                {
                    var num = int.Parse(command.Split("Delete ", StringSplitOptions.RemoveEmptyEntries).First());
                    input.RemoveAll(n => n.Equals(num));

                    continue;
                }

                var inserts = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                input.Insert(int.Parse(inserts[2]), int.Parse(inserts[1]));
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}