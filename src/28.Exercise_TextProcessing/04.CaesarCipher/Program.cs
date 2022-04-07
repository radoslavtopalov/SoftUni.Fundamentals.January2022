using System;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.ToCharArray();

            foreach (var chr in input)
            {
                Console.Write((char)(chr + 3));
            }
        }
    }
}