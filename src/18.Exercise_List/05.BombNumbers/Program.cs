using System;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var input2 = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var bomb = input2[0];
            var bombPower = input2[1];

            for (var i = 0; i < input.Count; i++)
            {
                var bombIndex = input.IndexOf(bomb);
                if (bombIndex < 0)
                {
                    break;
                }

                for (var j = 0; j < bombPower; j++)
                {
                    if (!(bombIndex - 1 < 0))
                    {
                        input.RemoveAt(bombIndex - 1);
                    }

                    bombIndex = input.IndexOf(bomb);

                    if (!(bombIndex + 1 > input.Count - 1))
                    {
                        input.RemoveAt(bombIndex + 1);
                    }

                }
                input.RemoveAt(bombIndex);
            }

            Console.WriteLine(input.Sum());
        }
    }
}