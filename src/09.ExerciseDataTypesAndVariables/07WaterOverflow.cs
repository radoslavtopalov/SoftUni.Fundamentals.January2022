//using System;

//namespace _07WaterOverflow
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var linesNumber = int.Parse(Console.ReadLine());
//            var tank = 0;

//            for (var i = 0; i < linesNumber; i++)
//            {
//                var littersToPour = int.Parse(Console.ReadLine());

//                if (tank + littersToPour <= 255)
//                {
//                    tank += littersToPour;
//                }
//                else
//                {
//                    Console.WriteLine("Insufficient capacity!");
//                }
//            }

//            Console.WriteLine(tank);
//        }
//    }
//}