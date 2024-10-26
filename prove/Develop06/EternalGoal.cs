public class EternalGoal : Goal
{
    public EternalGoal(): base("", "", "")
    {

    }

    public override void RecordEvent()
    {

    }

     public override bool IsComplete()
    {
        return true;
    }


    public override string GetStringRepresentation()
    {
        return "";
    }
}