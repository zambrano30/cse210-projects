using System;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public override void Start()
    {
        base.Start();
        
    }

    public override void Simulate()
    {
        base.Simulate();
        Console.WriteLine("List as many things as you can that make you happy!");
    }
}