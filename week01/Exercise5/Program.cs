using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        displayMessage();
        string name=promptUserName(); 
        int number=promptUserNumber();
        int squre =calculateSquare(number);
        displaySquare(number,squre,name);

    
    }
    static void displayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
        
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favoriteNumber = int.Parse(number);
        return favoriteNumber;
    }
    static int calculateSquare(int number)
    {
        return number*number;
    }
    static void displaySquare(int number, int square, string name)
    {
        Console.WriteLine($"Brother {name} the square of {number} is {square}.");
    }
}