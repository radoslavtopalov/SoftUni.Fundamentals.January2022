using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine()!);
            var second = int.Parse(Console.ReadLine()!);
            var third = int.Parse(Console.ReadLine()!);

            var sum = Sum(first, second);
            var subtracted = Subtracted(sum, third);

            Console.WriteLine(subtracted);
        }

        private static int Sum(int first, int second) => first + second;

        private static int Subtracted(int first, int second) => first - second;
    }
}