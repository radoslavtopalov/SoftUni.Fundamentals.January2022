using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userNames = Console.ReadLine()!
                .Split(", " , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var validUserNames = new List<string>();

            foreach (var userName in userNames)
            {
                var isValidUserName = Regex.IsMatch(userName, @"^[a-zA-Z0-9_-]{3,16}$");

                if (isValidUserName)
                {
                    validUserNames.Add(userName);
                }
            }

            foreach (var validUserName in validUserNames)
            {
                Console.WriteLine(validUserName);
            }
        }
    }
}