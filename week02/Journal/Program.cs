using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filename = "journal.txt";

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the date (YYYY-MM-DD): ");
                    string date = Console.ReadLine();

                    Console.Write("Enter a prompt (or type 'random'): ");
                    string prompt = Console.ReadLine();
                    if (prompt.ToLower() == "random")
                    {
                        prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Random Prompt: {prompt}");
                    }

                    Console.Write("Enter your journal entry: ");
                    string text = Console.ReadLine();

                    journal.AddEntry(new Entry(date, prompt, text));
                    Console.WriteLine("Entry added.");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.SaveToFile(filename);
                    Console.WriteLine("Journal saved to file.");
                    break;

                case "4":
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded from file.");
                    break;

                case "5":
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
