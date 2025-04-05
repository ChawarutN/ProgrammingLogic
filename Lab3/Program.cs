namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Part 1: Operator Practice

        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine( a > b && a > c);
        Console.WriteLine( a > b || a > c);

        //Part 2: Boolean Logic

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        //Part 3: Conditional Logic – Movie Ticket Pricing

        Console.WriteLine("Enter age: ");
        string input = Console.ReadLine();
        int age = int.Parse(input);
        Console.WriteLine(age);
        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if(age >= 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }

        //Part 4: Using a switch Statement

        int day = 8;
        switch (day) 
        {
        case 1:
        Console.WriteLine("Monday");
        break;
        case 2:
        Console.WriteLine("Tuesday");
        break;
        case 3:
        Console.WriteLine("Wednesday");
        break;
        case 4:
        Console.WriteLine("Thursday");
        break;
        case 5:
        Console.WriteLine("Friday");
        break;
        case 6:
        Console.WriteLine("Saturday");
        break;
        case 7:
        Console.WriteLine("Sunday");
        break;
        default:
        Console.WriteLine("Invalid day!");
        break;
        }
    }
}
