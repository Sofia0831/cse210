public class SimpleGoal : Goal
{
    private string _type = "Simple Goal:";
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public bool Finished()
    {
        return _isComplete;
    }

    public override void RecordEvent(List<Goal> goals)
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"[{(_isComplete ? "X" : " ")}] {GetDetailString()}";
    }

    public override string SaveGoal()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }

    public override string LoadGoal()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }
}