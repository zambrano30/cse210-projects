using System;

public class BreathingActivity :Activity // name of the class
{
    //Properties for the BreathingActivity class (fields)
    private int _inhaleDuration;
    private int _exhaleDuration;
    private int _totalBreaths;

    // Constructor to initialize the breathing activity

    public BreathingActivity(string activityName, string activityDescription, int duration, int _inhaleDuration, int exhaleDuration)

        : base(activityName, activityDescription, duration)// Call the base class Constructor
    {
        this._inhaleDuration = _inhaleDuration;
        this._exhaleDuration = exhaleDuration;
        _totalBreaths = duration / (_inhaleDuration + exhaleDuration);
    }


}