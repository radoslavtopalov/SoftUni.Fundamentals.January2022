using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, string>();

            for (var i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine();

                if (command.StartsWith("register"))
                {
                    var input = command.Split(' ');

                    if (users.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                        continue;
                    }

                    users.Add(input[1], input[2]);
                    Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                }

                if (command.StartsWith("unregister"))
                {
                    var input = command.Split(' ');

                    if (!users.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                        continue;
                    }

                    users.Remove(input[1]);
                    Console.WriteLine($"{input[1]} unregistered successfully");
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
