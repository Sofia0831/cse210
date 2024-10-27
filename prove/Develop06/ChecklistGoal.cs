public class CheckListGoal : Goal 
{
    private string _type = "Checklist Goal:";
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _status;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _status = false;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public CheckListGoal(string name, string description, int points, bool status, int target, int bonus, int count) : base(name, description, points)
    {
        _status = status;
        _target = target;
        _bonus = bonus;
        _amountCompleted = count;
    }

     public override void RecordEvent(List<Goal> goals)
    {

        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public int GetBonusPoints()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override string GetDetailString()
    {
        return base.GetDetailString() + $"({_bonus} points bonus)";
    
    }

    public override string GetStringRepresentation()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {GetDetailString()} -- Completed {_amountCompleted}/{_target}";
    }

    public override string SaveGoal()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}, {GetTarget()}, {GetBonusPoints()}, {GetAmountCompleted()}";
    }

    public override string LoadGoal()
    {
        return $"{_type}, {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}, {GetTarget()}, {GetBonusPoints()}, {GetAmountCompleted()}";
    }
}
