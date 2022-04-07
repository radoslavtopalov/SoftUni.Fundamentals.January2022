using System;

namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine()!);

            Print(input);
        }

        private static void Print(int number)
        {
            for (var i = 0; i < number; i++)
            {
                for (var j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}