public class EternalGoal : Goal
{
    private int _countPoints;
    public EternalGoal(string name, string description, int points): base(name, description, points)
    {
        _countPoints = 0;

        
    }

    public override void RecordEvent()
    {
        _countPoints++;
    
    }

     public override bool IsComplete()
    {
        return false;
    }


    public override string GetStringRepresentation()
    {
        return $"[ ] {GetDetailString()}";
    }
}