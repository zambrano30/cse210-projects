using System;

public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * Minutes / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;
}