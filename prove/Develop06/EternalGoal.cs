public class EternalGoal : Goal
{
    private int _eventCount;

    public EternalGoal(string name, string description, int points): base(name, description, points)
    {
        _eventCount = 0;
    }

    public override void RecordEvent()
    {
        _eventCount++;
    }

     public override bool IsComplete()
    {
        return false;
    }


    public override string GetStringRepresentation()
    {
        return $"[ ] {GetDetailString()} (Recorded {_eventCount} times)";
    }
}