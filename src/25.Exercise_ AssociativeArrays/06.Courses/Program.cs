using System;
using System.Collections.Generic;

namespace _06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(':');
            var courses = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {
                var courseComand = command[0].Trim();
                var studentComand = command[1].Trim();

                if (courses.ContainsKey(courseComand))
                {
                    courses[courseComand].Add(studentComand);
                }
                else
                {
                    courses.Add(courseComand, new List<string> { studentComand });
                }

                command = Console.ReadLine().Split(':');
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}