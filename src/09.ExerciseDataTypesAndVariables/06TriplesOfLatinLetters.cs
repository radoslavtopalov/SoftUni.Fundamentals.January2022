using System;

namespace _09.ExerciseDataTypesAndVariables
{
    internal class _06TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (var i = 0; i < number; i++)
            {
                for (var j = 0; j < number; j++)
                {
                    for (var k = 0; k < number; k++)
                    {
                        Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}");
                    }
                }
            }
        }
    }
}