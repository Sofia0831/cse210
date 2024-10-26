public class CheckListGoal : Goal 
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(int target, int bonus) : base("", "", "")
    {
        _target = target;
        _bonus = bonus;
    }

     public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailString()
    {
        return "";
    
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
