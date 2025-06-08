using System;

public class ReflectionActivity : Activity
{
    // Fields
    private string _reflectionPrompt;
    private string[] _reflectionQuestions;
    private int _totalReflections;

    // Constructor
    public ReflectionActivity(string activityName, string activityDescription, int duration, string reflectionPrompt, string[] reflectionQuestions)
        : base(activityName, activityDescription, duration)
    {
        _reflectionPrompt = reflectionPrompt;
        _reflectionQuestions = reflectionQuestions;
        _totalReflections = reflectionQuestions.Length;
    }

    // Override Simulate to show prompt and questions
    public override void Simulate()
    {
        base.Simulate();
        Console.WriteLine($"Prompt: {_reflectionPrompt}");
        foreach (var question in _reflectionQuestions)
        {
            Console.WriteLine($"- {question}");
        }
    }
}