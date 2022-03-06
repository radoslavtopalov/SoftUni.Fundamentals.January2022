using System;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shelf = Console.ReadLine();
            var command = Console.ReadLine();

            var books = shelf.Split("&").ToList();

            while (!command.Contains("Done"))
            {
                if (command.Contains("Add Book"))
                {
                    var bookToAdd = command
                        .Split("|").LastOrDefault()
                        .Remove(0, 1);

                    if (!books.Any(b => b.Contains(bookToAdd)))
                    {
                        books.Insert(0, bookToAdd);
                    }
                }
                else if (command.Contains("Take Book"))
                {
                    var bookToTake = command
                        .Split("|").LastOrDefault()
                        .Remove(0, 1);

                    books.Remove(bookToTake);
                }
                else if (command.Contains("Swap Books"))
                {
                    var commandElements = command.Split("|");

                    var firstBookToSwap = commandElements[1]
                        .Remove(0, 1)
                        .Remove(command.Split("|")[1].Length - 2, 1);
                    var secondBookToSwap = commandElements[2]
                        .Remove(0, 1);

                    if (books.Any(b => b.Contains(firstBookToSwap))
                        && books.Any(b => b.Contains(secondBookToSwap)))
                    {
                        var firstBookIndex = books.IndexOf(firstBookToSwap);
                        var secondBookIndex = books.IndexOf(secondBookToSwap);

                        var first = books[firstBookIndex];
                        var second = books[secondBookIndex];

                        books[firstBookIndex] = second;
                        books[secondBookIndex] = first;
                    }
                }
                else if (command.Contains("Insert Book"))
                {
                    var bookToInsert = command
                        .Split("|").LastOrDefault()
                        .Remove(0, 1);

                    if (!books.Any(b => b.Contains(bookToInsert)))
                    {
                        books.Add(bookToInsert);
                    }
                }
                else if (command.Contains("Check Book"))
                {
                    var bookToCheck = int.Parse(command
                        .Split("|").LastOrDefault()
                        .Remove(0, 1));

                    if (books.Count - 1 >= bookToCheck)
                    {
                        Console.WriteLine(books[bookToCheck]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
