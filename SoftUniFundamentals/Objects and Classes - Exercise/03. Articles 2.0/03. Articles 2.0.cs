using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < numberOfArticles; i++)
            {
                List<string> article = Console.ReadLine().Split(", ").ToList();
                string title = article[0];
                string content = article[1];
                string author = article[2];

                Article currArticle = new Article(title, content, author);

                articles.Add(currArticle);
            }

            string input = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
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

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
