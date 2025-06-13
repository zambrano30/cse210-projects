

public class CheckList : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;
    public CheckList(string shortName, string description, string points, int targetCount, int currentCount, int bonusPoints)
        : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }
    public override void RecordEvent()
    {
        if (_currentCount > _targetCount)
        {
            _currentCount++;
        }
    }
    public override bool IsComplete()
    {
        return _currentCount <= _targetCount;

    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]": "[]";
        return $"{status} {_shortName} ({_description}) -- Completed: {_currentCount}/{_targetCount}";
    }
    public override string GetStringRepresentantion()
    {
        return $"CheckListGoal |{_shortName} | {_description}| {_points} |{_bonusPoints}|{_currentCount}|{_targetCount}";
    }
        
}