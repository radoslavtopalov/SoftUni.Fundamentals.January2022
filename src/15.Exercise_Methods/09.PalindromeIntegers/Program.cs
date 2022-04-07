using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Contains("END"))
                {
                    break;
                }

                bool isPalindrome = input.Length == 1;

                if (input.Length % 2 != 0)
                {
                    var index = input.Length / 2;

                    for (var i = 0; i < index; i++)
                    {
                        for (int j = input.Length - 1; j > index; j--)
                        {
                            isPalindrome = input[i] == input[j];
                        }
                    }
                }
                else
                {
                    var index = input.Length / 2;

                    var firstPar = input
                        .Substring(0, index);
                    var secondPar = input
                        .Substring(index, index)
                        .ToCharArray()
                        .Reverse()
                        .ToArray();

                    isPalindrome = firstPar == new string(secondPar);

                }

                Console.WriteLine(isPalindrome.ToString().ToLower());
            }
        }
    }
}