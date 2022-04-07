using System;
using System.Linq;

namespace _37.PracticalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var newInput = input.ToCharArray();

            while (true)
            {
                var command = Console.ReadLine();

                if (command!.Contains("Abracadabra"))
                {
                    break;
                }

                if (command.Contains("Abjuration"))
                {
                    var newString = new string(newInput).ToUpper();
                    newInput = newString.ToCharArray();
                    Console.WriteLine(newString);

                }
                else if (command.Contains("Necromancy"))
                {
                    var newString = new string(newInput).ToLower();
                    newInput = newString.ToCharArray();
                    Console.WriteLine(newString);
                }
                else if (command.Contains("Illusion"))
                {
                    var index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    var letter = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2].ToCharArray().First();

                    if (index < input.Length)
                    {
                        newInput[index] = letter;

                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (command.Contains("Divination"))
                {
                    var firstSubstring = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                    var secondSubstring = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

                    var inputString = new string(newInput).Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (inputString[0].Contains(firstSubstring))
                    {
                        var newString = new string(newInput).Replace(firstSubstring, secondSubstring);
                        newInput = newString.ToCharArray();

                        Console.WriteLine(new string(newInput));
                    }
                }
                else if (command.Contains("Alteration"))
                {
                    var substring = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                    var inputString = new string(newInput).Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (inputString[0].Contains(substring, StringComparison.Ordinal))
                    {
                        var newString = new string(newInput).Replace(substring, "");
                        newInput = newString.ToCharArray();

                        Console.WriteLine(new string(newInput));
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}