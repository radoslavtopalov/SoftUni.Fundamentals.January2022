using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine()!);
            var students = new List<Student>();

            for (var i = 0; i < studentsCount; i++)
            {
                var input = Console.ReadLine()!.Split(' ');
                var student = new Student { FirstName = input[0], LastName = input[1], Grade = double.Parse(input[2]) };

                students.Add(student);
            }

            var orderedStudents = students.OrderByDescending(s => s.Grade);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}
