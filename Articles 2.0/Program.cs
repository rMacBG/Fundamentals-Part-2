namespace Articles_2._0
{

    public class Article
    {
        public Article(string title, string contnet, string author)
        {
            this.Title = title;
            this.Content = contnet;
            this.Author = author;
        }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Article> articles = new List<Article>();
            
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] article = Console.ReadLine()
                .Split(", ")
                .ToArray();
                Article ar = new Article(article[0], article[1], article[2]);
                articles.Add(ar);
            }
            //foreach (Article article in articles)
            //{
            //    Console.WriteLine(article);
            //}
            Console.WriteLine(string.Join("\n", articles));
        }
    }
}