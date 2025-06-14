using System;

public class Activity
{
    // Private fields
    private string _activityName;
    private string _activityDescription;
    private int _duration;

    public string ActivityName => _activityName;
    public string ActivityDescription => _activityDescription;
    public int Duration => _duration;

    // Constructor
    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting: {_activityName} - {_activityDescription} ({_duration} min)");
    }

    public virtual void Simulate()
    {
        Console.WriteLine($"Simulating: {_activityName}");
    }

    public virtual void End()
    {
        Console.WriteLine($"Ending: {_activityName}");
    }
}