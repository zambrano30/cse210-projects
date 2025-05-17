using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was your favorite part of the day?",
        "What did you learn today?",
        "Describe a moment that made you smile.",
        "What challenged you today?",
        "How did you help someone today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}

