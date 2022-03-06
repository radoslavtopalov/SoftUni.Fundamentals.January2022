//using System;

//namespace _09SpiceMustFlow
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var startingYield = int.Parse(Console.ReadLine());

//            var operatedDays = 0;
//            var extractedSpices = 0;

//            while (startingYield >= 100)
//            {
//                extractedSpices += startingYield;
//                extractedSpices -= 26;
//                operatedDays += 1;

//                startingYield -= 10;
//            }

//            if (startingYield < 100)
//            {
//                if (extractedSpices >= 26)
//                {
//                    extractedSpices -= 26;
//                } 
//            }

//            Console.WriteLine(operatedDays);
//            Console.WriteLine(extractedSpices);
//        }
//    }
//}