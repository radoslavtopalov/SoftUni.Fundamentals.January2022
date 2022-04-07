using System;
using System.Linq;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine()!);
            var secondNum = int.Parse(Console.ReadLine()!);
            var thirdNum = int.Parse(Console.ReadLine()!);

            var arr = new[] { firstNum, secondNum, thirdNum };

            Print(arr);
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(arr.Min());
        }
    }
}