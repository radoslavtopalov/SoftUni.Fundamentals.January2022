using System;
using System.Linq;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstChr = Console.ReadLine()!.ToCharArray().First();
            var secondChr = Console.ReadLine()!.ToCharArray().First();

            Print(firstChr, secondChr);
        }

        private static void Print(char first, char second)
        {
            if (first > second)
            {
                for (int i = second + 1; i < first; i++)
                {
                    Console.Write((char)i + " ");
                }
                return;
            }

            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}