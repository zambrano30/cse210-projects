using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Insert your grade: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";
        if (grade >=90)
        {   
            letter="A";
        }
        else if (grade>=80)
        {
            letter="B";

        }
        else if (grade>=70)
        {
            letter="C";

        }
         else if (grade>=60)
        {
            letter="D";

        }
         else if (grade<60)
        {
            letter="F";     
         }

         Console.WriteLine($"Your grade is : {letter}");

         if (grade >=70)
         {
            Console.WriteLine("You passed the course.");

         }
         else{
            Console.WriteLine("You failed the course, keep trying the next time.");
         }
    }
}