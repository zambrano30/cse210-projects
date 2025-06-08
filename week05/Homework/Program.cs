using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Christopher Zambrano ", "Python Basics");
        Console.WriteLine(assignment.GetSummary());

    }
}

