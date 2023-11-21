namespace Articles
{

    public class Article
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


        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    public class Program
    {
        static void Main()
        {
            string[] article = Console.ReadLine()
                .Split(", ")
                .ToArray();


            Article ar = new Article(article[0], article[1], article[2]);
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ")
                    .ToArray();
                switch (command[0])
                {
                    case "Edit":
                        string newContent = command[1];
                        ar.Edit(newContent);

                        break;
                    case "ChangeAuthor":
                        string newAuthor = command[1];
                        ar.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = command[1];
                        ar.Rename(newTitle);
                        break;
                }
            }
            Console.WriteLine(ar.ToString());
        }
    }
}