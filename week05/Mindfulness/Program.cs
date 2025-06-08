using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        // Create instances of the activities
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Exercise", "Focus on your breath to relax and center yourself.", 5, 4, 6);
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Time", "Take a moment to reflect on your thoughts and feelings.", 5, "What are you grateful for?", new string[] { "What did you learn today?", "How can you apply this learning?" });
        ListingActivity listingActivity = new ListingActivity("Listing Exercise", "List down things that make you happy.", 5);
        // Start the activities
        breathingActivity.Start();
        reflectionActivity.Start();
        listingActivity.Start();
        // Simulate the activities
        breathingActivity.Simulate();
        reflectionActivity.Simulate();
        listingActivity.Simulate();
        // End the activities
        breathingActivity.End();
        reflectionActivity.End();
        listingActivity.End();

        Console.WriteLine("Thank you for participating in the Mindfulness Project!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}