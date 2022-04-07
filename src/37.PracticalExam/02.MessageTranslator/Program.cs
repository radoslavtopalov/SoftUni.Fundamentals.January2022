using System;
using System.Linq;

namespace _02.MessageTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < inputNumber; i++)
            {
                var command = Console.ReadLine();

                var isColonExists = command.Contains(":");
                var com = command.Split(':', StringSplitOptions.RemoveEmptyEntries).First();
                var isStartingWith = com.StartsWith("!");
                var isEndingWith = com.EndsWith("!");
                var isLengthCorrect = com.Length - 2 >= 3;
                var isAfterComandLettersOnly = false;
                var isAfterComandCorrectCount = false;

                var isWithFirstLetterUpperCase = char.IsUpper(com[1]);
                var isRestLettersOk = false;
                for (int j = 2; j < com.Length - 1; j++)
                {
                    isRestLettersOk = char.IsLower(com[j]);
                    if (isRestLettersOk == false)
                    {
                        break;
                    }
                }

                var com2 = command.Split(':', StringSplitOptions.RemoveEmptyEntries).Last();
                isAfterComandCorrectCount = com2.Length >= 8;
                for (int c = 1; c < com2.Length - 1; c++)
                {
                    isAfterComandLettersOnly = char.IsLetter(com2[c]);
                    if (isAfterComandLettersOnly == false)
                    {
                        break;
                    }
                }

                var isValid = isColonExists && isStartingWith && isEndingWith && isLengthCorrect && isAfterComandLettersOnly &&
                              isAfterComandCorrectCount && isWithFirstLetterUpperCase && isRestLettersOk;

                if (isValid)
                {
                    var strinngArr = command.Split('[', StringSplitOptions.RemoveEmptyEntries);
                    var stringComand = strinngArr[0]
                        .Remove(0, 1);
                    stringComand = stringComand.Remove(strinngArr[0].Length - 3, 1);
                    var @string = strinngArr[1].Remove(strinngArr[1].Length - 1);

                    Console.Write(stringComand);
                    for (int j = 0; j < @string.Length; j++)
                    {
                        Console.Write($" {(int)@string[j]}");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
