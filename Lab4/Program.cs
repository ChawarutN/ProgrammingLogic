namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        //Part 1: Simple For Loop

        int c = 1;
        while (c < 11)
        {
            Console.WriteLine(c);
            c++;
        }


        //Part 2:  Even Numbers from 1 to 20 (Using Modulus Operator)

        for (int n = 1; n <= 20; n++)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
        }


        //Part 3: While Loop Countdown

        int i = 5;
        while (i >= 1) 
        {
            Console.WriteLine(i);
            i--;
        }

        //Part 4: Do/While User Input

        int number;

        do
        {
            Console.WriteLine("Enter a number greater than 100: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 100)
            {
                Console.WriteLine("Invalid Number. 55Please enter a valid number: ");
            }
        }

        while (number < 100);
        
            Console.WriteLine("You enter a valid number: " + number );
        

        //Part 5: While Loop – Multiples of 10 from 10 to 1000

        int f = 10;

        while(f <= 1000)
        {
            Console.WriteLine(f);
            f += 10;
        }


        //Part 6: Pattern Printer (Using Nested Loops)

        for (int g = 1; g <= 10; g++)
        {
            for (int k = 1; k <= g; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
