using System;

class Car
{
  public string model;
  public string color;
  public int year;

  
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  //Part 1: Add a Method with No Parameters

  public void Start()
  {
    Console.WriteLine("The car is starting.");
  }

  //Part 2: Add a Method with Parameters

  public void Drive(int miles)
  {
    Console.WriteLine($"The car drove {miles} miles.");
  }

  //Part 3: Add a Method with a Return Value
  
  public string GetDescription()
  {
    return $"{year} {color} {model}";
  }

  //Part 4: Add a Method that Updates a Field

  public void Repaint(string newColor)
  {
    color = newColor;
    Console.WriteLine($"The car has been repainted to {color}.");
  }
}

class Program
{
  static void Main()
  {
   
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    //Calling Methods

    myCar.Display(); 
    myCar.Start();
    myCar.Drive(50);

    //Storing and Printing the Description

    string description = myCar.GetDescription();
    Console.WriteLine(description);

    //Changing the car's color

    myCar.Repaint("Red");
  }
}