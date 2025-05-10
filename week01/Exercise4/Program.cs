using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int number = -1;


        Console.WriteLine("Enter a list of numbers , type 0 when finished: ");
        while (number != 0)
        {

            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            
            
            if (number != 0)
            {
                numbers.Add(number);
                
            }
        }
        int sum=0;
        foreach(int num in numbers)
        {
            sum +=num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");



        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num >max)
            {
                max =num;
            }
        
        }
        
            Console.WriteLine($"The max number is: {max}");
    }

}