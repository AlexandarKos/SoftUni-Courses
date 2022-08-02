using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
    }
}
