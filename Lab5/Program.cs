namespace Lab5;

class Program
{
    static void Main(string[] args)
    {

        //Part 1: Seasons of the Year

        string [] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine($"Season: {season}");
        }

        //Part 2: Days of the Week

        string [] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.WriteLine("Enter a number (1-7): ");

        if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 7)
        {
            Console.WriteLine($"That day is: {days[number - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7");
        }
        
        //Part 3: Favorite Books and Authors

        string [] books = { "The Hobbit", "Charlotte's Web", "1984" };
        string [] authors = { "J.R.R. Tolkien", "E.B White", "George Orwell" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: {books[i]} by {authors[i]}");
        }

        //Part 4: Temperature Tracker

        int [] temperatures = { 65, 72, 78, 70, 68 };

        Array.Sort(temperatures);

        Console.Write("Sorted Temeratures: ");
        foreach (int temp in temperatures)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Highest Temperature: {temperatures[temperatures.Length - 1]}");
        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");

        //Part 5: Reverse Countdown

        int [] countdown = { 5, 4, 3, 2, 1};

        Array.Reverse(countdown);

        Console.Write("Countdown: ");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(countdown[i] + " ");
        }
        Console.WriteLine();

    }
}
