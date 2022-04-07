using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    public class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input.Any(i => i == "End"))
                    break;

                var name = input[0];
                var id = input[1];
                var age = int.Parse(input[2]);

                var isIdExist = people.Any(p => p.Id == id);
                if (isIdExist)
                {
                    var personToUpdate = people.Find(p => p.Id == id); // might need to check it`s only one

                    personToUpdate.Name = name;
                    personToUpdate.Age = age;
                    continue;
                }

                people.Add(new Person { Name = name, Id = id, Age = age });
            }

            var orderedPeople = people.OrderBy(p => p.Age).ToList();
            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}