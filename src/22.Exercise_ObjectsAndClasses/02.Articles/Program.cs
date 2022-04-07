using System;
using System.Linq;

namespace _02.Articles
{
    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToList();
            var numberOfCommands = int.Parse(Console.ReadLine());

            var article = new Article() {Title = input[0], Content = input[1], Author = input[2]};

            for (var i = 0; i < numberOfCommands; i++)
            {
                var actionCommand = Console.ReadLine();

                if (actionCommand.StartsWith("Edit"))
                {
                    article.Edit(actionCommand.Remove(0, 5).Trim());
                    continue;
                }
                
                if (actionCommand.StartsWith("ChangeAuthor"))
                {
                    article.ChangeAuthor(actionCommand.Remove(0, 13).Trim());
                    continue;
                }

                if (actionCommand.StartsWith("Rename"))
                {
                    article.Rename(actionCommand.Remove(0, 7).Trim());
                }
            }

            Console.WriteLine($"{article.ToString()}");
        }
    }
}
