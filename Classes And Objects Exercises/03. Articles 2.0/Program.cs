using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> listArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articles = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = articles[0];
                string content = articles[1];
                string author = articles[2];

                Article article = new Article(title, content, author);
                listArticles.Add(article);
            }

            Console.WriteLine(string.Join(Environment.NewLine, listArticles));
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}