using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articles = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = articles[0];
            string content = articles[1];
            string author = articles[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmndArrs = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmndArrs[0];
                string newValue = cmndArrs[1];

                if (command == "Edit")
                {
                    article.Edit(newValue);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newValue);
                }
                else
                {
                    article.Rename(newValue);
                }
            }
            Console.WriteLine(article);
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

            public void Edit (string content)
            {
                Content = content;
            }
            
            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public void Rename(string title)
            {
                Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}