using System;
using System.Linq;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.ToCharArray().ToList();
            var currentStrength = 0;

            for (var i = 0; i < input.Count; i++)
            {
                if (input[i] == '>')
                {
                    currentStrength = currentStrength + input[i + 1] - 48;
                    var possiblePositionToRemove = 0;

                    for (var j = i + 1; j < input.Count; j++)
                    {
                        if (input[j] != '>')
                        {
                            possiblePositionToRemove++;
                            continue;
                        }

                        break;
                    }

                    if (currentStrength <= possiblePositionToRemove)
                    {
                        input.RemoveRange(i + 1, currentStrength);
                        currentStrength = 0;
                    }
                    else if (currentStrength > possiblePositionToRemove)
                    {
                        input.RemoveRange(i + 1, possiblePositionToRemove);
                        currentStrength -= possiblePositionToRemove;
                    }
                }
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}