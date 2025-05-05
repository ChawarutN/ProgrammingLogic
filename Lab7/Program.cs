namespace Lab7;
    
    public class Book
    {
        
        private string author;
        private string title;
        
        public Book()
        {
            title = "Unknown Title";
            author = "Unknown Author";
        }

        public Book(string newTitle)
        {
            title = newTitle;
            author = "Unknown Author";
        }

        public Book(string newTitle, string newAuthor)
        {
            title = newTitle;
            author = newAuthor;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }

        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string newAuthor)
        {
            author = newAuthor;
        }
    }
    
     class Program
    {
        static void Main(string[] args)
        {
           Book book1 = new Book();
            Console.WriteLine(book1.GetTitle());
            book1.SetTitle("C# Fundamentals");
            Console.WriteLine(book1.GetTitle());

           Book book2 = new Book("Advanced C#");
            Console.WriteLine(book2.GetTitle());

           Book book3 = new Book("Advanced C#", "John Doe");
            Console.WriteLine($"Title: {book3.GetTitle()}");
            Console.WriteLine($"Author: {book3.GetAuthor()}");

           Book book4 = new Book();
            book4.SetTitle("Mastering C#");
            book4.SetAuthor("Jane Smith");
            Console.WriteLine($"Title: {book4.GetTitle()}");
            Console.WriteLine($"Author: {book4.GetAuthor()}");
        }
    }
