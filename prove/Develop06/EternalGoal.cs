public class EternalGoal : Goal
{
    private string _type = "Eternal Goal:";
    private int _eventCount;

    public EternalGoal(string name, string description, int points): base(name, description, points)
    {
        _eventCount = 0;
    }

    public override void RecordEvent(List<Goal> goals)
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

    public override string SaveGoal()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
    }

    public override string LoadGoal()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
    }
}