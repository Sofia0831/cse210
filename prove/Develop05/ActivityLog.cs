public static class ActivityLogger
{
    private static Dictionary<string, int> activityCounts = new Dictionary<string, int>();

    public static void LogActivityCompletion(string activityName)
    {
        if (!activityCounts.ContainsKey(activityName))
        {
            activityCounts[activityName] = 0;
        }
        activityCounts[activityName]++;
    }

    public static void DisplayActivityCounts()
    {
        Console.WriteLine("Activity Counts:");
        foreach (var activity in activityCounts)
        {
            Console.WriteLine($"{activity.Key}: {activity.Value}");
        }
    }
}