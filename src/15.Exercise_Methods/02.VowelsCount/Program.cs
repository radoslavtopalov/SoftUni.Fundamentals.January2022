using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .ToCharArray();

            Print(input);
        }

        private static void Print(char[] chr)
        {
            var total = 0;

            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] == 'a' || chr[i] == 'e' || chr[i] == 'i' || chr[i] == 'o' || chr[i] == 'u')
                {
                    total++;
                }
            }

            Console.WriteLine(total);
        }
    }
}