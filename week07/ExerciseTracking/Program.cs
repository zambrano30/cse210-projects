using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 06, 15), 30, 5),
            new Cycling(new DateTime(2025, 06, 16), 30, 10),
            new Swimming(new DateTime(2025, 06, 17), 30, 25)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}