using System;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstHand = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var secondHand = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstHand.Count != 0 && secondHand.Count != 0)
            {
                if (firstHand.First() == secondHand.First())
                {
                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);

                    continue;
                }

                if (firstHand.First() > secondHand.First())
                {
                    firstHand.Add(firstHand.First());
                    firstHand.Add(secondHand.First());

                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
                else
                {
                    secondHand.Add(secondHand.First());
                    secondHand.Add(firstHand.First());

                    firstHand.RemoveAt(0);
                    secondHand.RemoveAt(0);
                }
            }

            Console.WriteLine(firstHand.Count != 0
                ? $"First player wins! Sum: {firstHand.Sum()}"
                : $"Second player wins! Sum: {secondHand.Sum()}");
        }
    }
}