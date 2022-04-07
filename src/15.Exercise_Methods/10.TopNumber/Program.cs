using System;
using System.Linq;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            for (var i = 1; i <= int.Parse(input); i++)
            {
                var t = IsDivisibleBy(i.ToString(), 8);
                var t1 = IsWithAtLeastOneOddDigit(i.ToString());

                if (t && t1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDivisibleBy(string num, int divider)
        {
            var number = num.Sum(s => s - '0');

            return number % divider == 0;
        }

        private static bool IsWithAtLeastOneOddDigit(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if ((int)str[i] % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}