

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points)
     : base(shortName, description, points)
    {
    }
        public override void RecordEvent()
    {
        Console.WriteLine("The event was registered for eternal goal.");

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentantion()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
    
}