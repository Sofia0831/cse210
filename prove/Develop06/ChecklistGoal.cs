public class CheckListGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

     public override void RecordEvent(List<Goal> goals)
    {
        _amountCompleted++;
    }

    public int GetBonusPoints()
    {
        return _bonus;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailString()
    {
        return base.GetDetailString() + $"({_bonus} points bonus)";
    
    }

    public override string GetStringRepresentation()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {GetDetailString()} (Completed {_amountCompleted}/{_target})";
    }
}
