using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine()!);
            var second = double.Parse(Console.ReadLine()!);

            var firstFactorial = CalculateFactorial(first);
            var secondFactorial = CalculateFactorial(second);

            Print(firstFactorial, secondFactorial);
        }

        private static double CalculateFactorial(double number)
        {
            var factorial = number;

            for (var i = 1; i < number; i++)
            {
                factorial = factorial * (number - i);
            }

            return factorial;
        }

        private static void Print(double first, double second)
        {
            var result = (first / second);
            Console.WriteLine($"{result:F2}");
        }
    }
}