using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2025-10-10", 30, 5.0),
            new Cycling("2025-10-11", 60, 20.0, 300),
            new Swimming("2025-10-12", 45, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}