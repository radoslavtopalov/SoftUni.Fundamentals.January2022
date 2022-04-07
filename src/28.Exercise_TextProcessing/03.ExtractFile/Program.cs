using System;
using System.Linq;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var input = Console.ReadLine()!.Split("\\");

           Console.WriteLine($"File name: {input.Last().Split('.').First()}");
           Console.WriteLine($"File extension: {input.Last().Split('.').Last()}");
        }
    }
}