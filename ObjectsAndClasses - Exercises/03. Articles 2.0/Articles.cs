using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Articles
{
    class Catalouge
    {
        public List<Article> ArticleCatalouge { get; set; }
    }
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
        //public override string ToString(string property)
        //{
        //    return $"{this.Title} - {this.Content}: {this.Author}";
        //}

    }
    class Articles
    {
        static void Main()
        {
            var catalouges = new Catalouge();
            catalouges.ArticleCatalouge = new List<Article>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                var currentArticle = new Article(input[0], input[1], input [2]);

                catalouges.ArticleCatalouge.Add(currentArticle);
            }
            string property = Console.ReadLine();

            if (property == "title")
            {
                if (catalouges.ArticleCatalouge.Count > 0)
                {
                    foreach (var item in catalouges.ArticleCatalouge.OrderBy(i => i.Title))
                    {
                        Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                    }
                }
            }
            else if (property == "content")
            {
                if (catalouges.ArticleCatalouge.Count > 0)
                {
                    foreach (var item in catalouges.ArticleCatalouge.OrderBy(i => i.Content))
                    {
                        Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                    }
                }
            }
            else if (property == "author")
            {
                if (catalouges.ArticleCatalouge.Count > 0)
                {
                    foreach (var item in catalouges.ArticleCatalouge.OrderBy(i => i.Author))
                    {
                        Console.WriteLine($"{item.Title} - {item.Content}: {item.Author}");
                    }
                }
            }
        }
    }
}
