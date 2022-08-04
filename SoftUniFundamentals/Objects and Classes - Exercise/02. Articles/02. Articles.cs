using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> article = Console.ReadLine().Split(", ").ToList();
            string title = article[0];
            string content = article[1];
            string author = article[2];

            int numberOfCommands = int.Parse(Console.ReadLine());

            Article newArticle = new Article(title, content, author);

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(": ").ToList();
                string command = commands[0];

                switch (command)
                {
                    case "Edit":
                        string newContent = commands[1];
                        newArticle.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = commands[1];
                        newArticle.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = commands[1];
                        newArticle.Rename(newTitle);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(newArticle);
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
        public void Edit(string newContent) => Content = newContent;

        public void ChangeAuthor(string newAuthor) => Author = newAuthor;

        public void Rename(string newTitle) => Title = newTitle;

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
