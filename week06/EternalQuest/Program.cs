using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Select goal type: 1) Simple 2) Eternal 3) Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Short name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    string pts = Console.ReadLine();

                    if (type == "1")
                        goals.Add(new SimpleGoal(name, desc, pts));
                    else if (type == "2")
                        goals.Add(new EternalGoal(name, desc, pts));
                    else if (type == "3")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goals.Add(new CheckList(name, desc, pts, target, 0, bonus));
                    }
                    break;

                case "2":
                    Console.WriteLine("\nYour Goals:");
                    int i = 1;
                    foreach (Goal g in goals)
                    {
                        Console.WriteLine($"{i}. {g.GetDetailsString()}");
                        i++;
                    }
                    break;

                case "3":
                    Console.WriteLine("Which goal did you accomplish?");
                    for (int j = 0; j < goals.Count; j++)
                        Console.WriteLine($"{j + 1}. {goals[j].GetDetailsString()}");
                    int idx = int.Parse(Console.ReadLine()) - 1;
                    goals[idx].RecordEvent();
                    // Suma puntos según el tipo de goal (puedes mejorar esto)
                    // Ejemplo: score += int.Parse(goals[idx].Points);
                    break;

                case "4":
                    Console.WriteLine($"Your current score is: {score}");
                    break;

                case "5":
                    // Implementa guardar a archivo
                    Console.WriteLine("Saving goals... (implement this)");
                    break;

                case "6":
                    // Implementa cargar desde archivo
                    Console.WriteLine("Loading goals... (implement this)");
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }
}