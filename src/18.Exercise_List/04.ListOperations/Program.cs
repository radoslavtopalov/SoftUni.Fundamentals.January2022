using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()!
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine()!;


                if (command.Contains("End"))
                {
                    break;
                }

                if (command.Contains("Add"))
                {
                    var num = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    nums.Add(int.Parse(num[1]));
                }

                if (command.Contains("Remove"))
                {
                    var num = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    var index = int.Parse(num.Last());
                    if (index >= 0 && index < nums.Count)
                    {
                        nums.RemoveAt(int.Parse(num[1]));
                        continue;
                    }

                    Console.WriteLine($"Invalid index");
                }

                if (command.Contains("Insert"))
                {
                    var num = command
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var number = int.Parse(num[1]);
                    var index = int.Parse(num[2]);

                    if (index >= 0 && index < nums.Count)
                    {
                        nums.Insert(index, number);
                        continue;
                    }

                    Console.WriteLine("Invalid index");
                }

                if (command.Contains("Shift left"))
                {
                    if (nums.Count > 1)
                    {
                        var num = command
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var numberOfShifts = int.Parse(num[2]);

                        ShiftLeft(nums, numberOfShifts);
                    }
                }

                if (command.Contains("Shift right"))
                {
                    if (nums.Count > 1)
                    {
                        var num = command
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        var numberOfShifts = int.Parse(num[2]);

                        ShiftRight(nums, numberOfShifts);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void ShiftLeft(List<int> list, int shifts)
        {
            for (var i = 0; i < shifts; i++)
            {
                var firstElement = list[0];
                for (var j = 0; j < list.Count - 1; j++)
                {
                    list[j] = list[j + 1];
                }

                list[list.Count - 1] = firstElement;
            }
        }

        private static void ShiftRight(List<int> list, int shifts)
        {
            for (var i = 0; i < shifts; i++)
            {
                var lastElement = list[list.Count - 1];
                for (var j = list.Count - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }

                list[0] = lastElement;
            }
        }
    }
}