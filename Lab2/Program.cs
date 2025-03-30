using System.Reflection.Metadata;
using System.Transactions;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Part 1: Variable Declarations

        int myNumber = 46;
        double doubleVariable = 22e3D;
        float  floatVariable = 44e4F;
        char charVariable = 'C';
        bool codingIsInteresting = true; 
        string stringVariable = "I am learnging C-Sharp";

        Console.WriteLine(myNumber);
        Console.WriteLine(doubleVariable);
        Console.WriteLine(floatVariable);
        Console.WriteLine(charVariable);
        Console.WriteLine(codingIsInteresting);
        Console.WriteLine(stringVariable);

        //Part 2: Type Casting

        double myDouble = 9.78;
        int myInt = (int) myDouble;
        bool myBool = true;
        string intToString = Convert.ToString(myInt);
        string boolToString = Convert.ToString(myBool);

        Console.WriteLine(myDouble);
        Console.WriteLine(myInt);
        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToString(myBool));
        Console.WriteLine("double:" + myDouble);
        Console.WriteLine("int:" + myInt);
        Console.WriteLine("bool:" + myBool);
        Console.WriteLine("string:" + intToString);
        Console.WriteLine("string:" + boolToString);

        //Part 3: User Input and Type Conversion

        Console.WriteLine("Enter username: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);

        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Hello, " + userName + "." + " Congratulation you turned " + age + "!");

        //Part 4: Arithmetic Operators

        int num1 = 10;
        int num2 = 20;
        int addition = num1+num2;
        int subtraction = num1+num2;

        Console.WriteLine("Addition " + (addition + 10));
        Console.WriteLine("Subtraction " + (addition - 2));
        Console.WriteLine("Multiplication " + (addition * 3));
        Console.WriteLine("Division " + (addition / 2));
        Console.WriteLine("Modulus " + (addition % 2));

        //Part 5: Floating Point Precision

        float myNum = 1.123456789F;
        double myNumb = 1.123456789D;

        Console.WriteLine(myNum);
        Console.WriteLine(myNumb);

        //Part 6: Increment and Decrement

        int x = 10;
        x++;
        Console.WriteLine(x);
        x--;
        Console.WriteLine(x);
    }
}
