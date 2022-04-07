using System;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var secondArr = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            for (var i = 0; i < secondArr.Length; i++)
            {
                for (var j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j] == secondArr[i])
                    {
                        Console.Write(secondArr[i] + " ");
                    }
                }
            }
        }
    }
}