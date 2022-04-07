using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    public class Article2
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var NumberOfArticles = int.Parse(Console.ReadLine());
            var articles = new List<Article2>();

            for (var i = 0; i < NumberOfArticles; i++)
            {
                var input = Console.ReadLine()
                    .Split(',')
                    .Select(i => i.Trim())
                    .ToList();


                articles.Add(new Article2 { Title = input[0], Content = input[1], Author = input[2] });

            }

            var final = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine($"{article.ToString()}");
            }

            //Console.WriteLine($"{final}");
        }
    }
}