//using System;

//namespace _08BeerKegs
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var kegsNumber = int.Parse(Console.ReadLine());

//            var biggestVolume = 0m;
//            var biggestKegName = string.Empty;

//            for (var i = 0; i < kegsNumber; i++)
//            {
//                var model = Console.ReadLine();
//                var radius = decimal.Parse(Console.ReadLine());
//                var height = long.Parse(Console.ReadLine());

//                var volume = (decimal)Math.PI * (radius * radius) * height;

//                if (volume > biggestVolume)
//                {
//                    biggestVolume = volume;
//                    biggestKegName = model;
//                }
//            }

//            Console.WriteLine($"{biggestKegName}");
//        }
//    }
//}