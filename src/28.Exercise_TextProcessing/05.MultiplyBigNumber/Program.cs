using System;
using System.Collections.Generic;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()!;
            firstInput = firstInput.TrimStart(new char[] { '0' });
            var number = int.Parse(Console.ReadLine()!);

            var parse = 0;
            var newInput = new List<int>();

            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (var i = firstInput.Length - 1; i >= 0; i--)
            {
                parse = (int.Parse(Convert.ToString(firstInput[i])) * number) + parse;
                newInput.Insert(0, (parse % 10));
                parse /= 10;
            }

            Console.WriteLine(parse > 0
                    ? $"{parse}{string.Join("", newInput)}"
                    : $"{string.Join("", newInput)}");
        }
    }
}