using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Print(input);
        }

        private static void Print(string str)
        {
            if (str.Length % 2 == 0)
            {
                var firstIndex = str[(str.Length / 2) - 1];
                var secondIndex = str[str.Length / 2];

                Console.WriteLine(firstIndex.ToString() + secondIndex);
            }
            else
            {
                Console.WriteLine(str[str.Length / 2]);
            }
        }
    }
}