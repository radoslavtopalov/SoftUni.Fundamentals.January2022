using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var firstInput = input[0].ToCharArray();
            var secondInput = input[1].ToCharArray();

            var total = 0;

            if (input[0].Length == input[1].Length)
            {
                for (var i = 0; i < firstInput.Length; i++)
                {
                    total += firstInput[i] * secondInput[i];
                }
            }
            else
            {
                if (firstInput.Length > secondInput.Length)
                {
                    for (var i = 0; i < secondInput.Length; i++)
                    {
                        total += firstInput[i] * secondInput[i];
                    }

                    for (var i = secondInput.Length; i < firstInput.Length; i++)
                    {
                        total += firstInput[i];
                    }
                }
                else
                {
                    for (var i = 0; i < firstInput.Length; i++)
                    {
                        total += firstInput[i] * secondInput[i];
                    }

                    for (var i = firstInput.Length; i < secondInput.Length; i++)
                    {
                        total += secondInput[i];
                    }
                }
            }

            Console.WriteLine(total);
        }
    }
}