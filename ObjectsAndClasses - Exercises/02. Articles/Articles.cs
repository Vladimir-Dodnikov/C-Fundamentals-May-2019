using System;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
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
    }
    class Articles
    {
        static void Main()
        {
            string[] article = Console.ReadLine().Split(", ").ToArray();

            Article currentArticle = new Article(article[0], article[1], article[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ").ToArray();
                string command = input[0];
                string type = input[1];

                if (command == "Edit")
                {
                    currentArticle.Edit(type);
                }
                else if (command == "ChangeAuthor")
                {
                    currentArticle.ChangeAuthor(type);
                }
                else if (command == "Rename")
                {
                    currentArticle.Rename(type);
                }
            }
            Console.WriteLine($"{currentArticle.Title} - {currentArticle.Content}: {currentArticle.Author}");
        }
    }
}
