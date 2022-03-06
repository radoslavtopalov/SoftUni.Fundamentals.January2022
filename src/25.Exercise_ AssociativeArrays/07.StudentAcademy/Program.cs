using System;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string, double>();
            var studentsNumberOfGrades = new Dictionary<string, int>();

            for (var i = 0; i < numberOfLines; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsNumberOfGrades.Add(name, 1);
                    studentsGrades.Add(name, grade);
                }
                else
                {
                    studentsNumberOfGrades[name] += 1;
                    studentsGrades[name] += grade;
                }
            }

            var betterStudents = new Dictionary<string, double>();

            foreach (var student in studentsGrades)
            {
                var avr = student.Value / studentsNumberOfGrades[student.Key];

                if (avr >= 4.50)
                {
                    betterStudents.Add(student.Key, avr);
                }
            }

            foreach (var betterStudent in betterStudents)
            {
                Console.WriteLine($"{betterStudent.Key} -> {betterStudent.Value:F2}");
            }
        }
    }
}