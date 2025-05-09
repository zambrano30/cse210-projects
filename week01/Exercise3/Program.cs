using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("What is the magic number?: ");
        
        int magicNumber =15;

        while(true)
        {
            Console.Write("What is your guess?:");
            string  input = Console.ReadLine();
            int guess = int.Parse(input);
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input, please enter a number");
                continue;
            }
            
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                   break;
            }       
     }
        Console.WriteLine("Thank you for playing");
        

      }  
            
}    
