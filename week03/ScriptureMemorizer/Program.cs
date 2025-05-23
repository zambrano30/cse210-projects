using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // Create a new Reference object
        Reference _reference = new Reference("Alma", 7, 11);

        string scriptureText = "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.";
        Scripture scripture = new Scripture(_reference, scriptureText);
        while (true)
        {
            Console.Clear();
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Congratulations! You have memorized the scripture.");
                break;
            }
            Console.WriteLine("Press Enter to hide random words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}