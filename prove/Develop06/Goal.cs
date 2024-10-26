public abstract class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(List<Goal> goals);

    public abstract bool IsComplete();

    public virtual string GetDetailString()
    {
        return $"{_shortName}: {_description} - ({_points} points)";
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

}