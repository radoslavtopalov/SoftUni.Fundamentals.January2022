using System;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()!);
            var firstArr = new int[number];
            var secondArr = new int[number];

            for (var i = 0; i < number; i++)
            {
                var input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var firstNumber = int.Parse(input[0]);
                var secondNumber = int.Parse(input[1]);

                if (i % 2 == 0)
                {
                    firstArr[i] = firstNumber;
                    secondArr[i] = secondNumber;
                }
                else
                {
                    firstArr[i] = secondNumber;
                    secondArr[i] = firstNumber;
                }
            }

            foreach (var n in firstArr)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            foreach (var n in secondArr)
            {
                Console.Write(n + " ");
            }
        }
    }
}