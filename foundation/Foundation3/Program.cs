using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("Oct 29, 2024", "Running", 30, 3.0),
            new CyclingActivity("Oct 29, 2024", "Cycling", 45, 20.0),
            new SwimmingActivity("Oct 29, 2024", "Swimming", 35, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}